//======================================
//  GameCubeTest
//  Created on: 19.01.2026 0:13:30
//  Author: Vova43
//======================================
namespace tests.CubeTest {
    using platform;
    using openGL;
    using level;
    using renderer;
    using gui;
    using particle;
    using phys;
    using phys.vector;
    public class GameCubeTest : Test {
        public Level level = null;
        public Entity entity = null;
        public HitResult hitResult = null;

        private Matrix4f projectMatrix = new Matrix4f();
        private float[] projectMatrixMoss = new float[16];
        float xDeltaPos = 0;
        float yDeltaPos = 0;
        float zDeltaPos = 0;
        private void moveCameraToPlayer(float fractionalTicks) {
            Matrix4f.translate(-0, -0, -0.03F, projectMatrix, projectMatrix);
            Matrix4f.rotate(entity.xRot, 1.0f, 0.0f, 0.0f, projectMatrix, projectMatrix);
            Matrix4f.rotate(entity.yRot, 0.0f, 1.0f, 0.0f, projectMatrix, projectMatrix);
            Matrix4f.rotate(0, 0, 0, 1.0f, projectMatrix, projectMatrix);
            xDeltaPos = entity.xo + (entity.x - entity.xo) * fractionalTicks;
            yDeltaPos = entity.yo + (entity.y - entity.yo) * fractionalTicks;
            zDeltaPos = entity.zo + (entity.z - entity.zo) * fractionalTicks;
            Matrix4f.translate(-xDeltaPos, -yDeltaPos, -zDeltaPos, projectMatrix, projectMatrix);
            projectMatrix.store(projectMatrixMoss);
            unsafe { GL11.glLoadMatrixf((float*)Mem.getArrayTempAddress(projectMatrixMoss)); }
        }

        private float fovyRadians = (float)System.Math.Tan(70 * 0.5 * 3.1415F / 180); // 70 / 2 * 3.1415F / 180;
        private void setupCamera(float fractionalTicks, int width, int height) {
            projectMatrix.setIdentity();
            MatrixUtils.projection(fovyRadians, (float)width / height, 0.05F, 250.0F, projectMatrix);
            moveCameraToPlayer(fractionalTicks);
        }

        ScaledResolution scaledResolution;
        private void setupCameraGui() {
            projectMatrix.setIdentity();
            MatrixUtils.ortho(0.0f, scaledResolution.scaledWidthF, scaledResolution.scaledHeightF, 0.0f, 0.0f, 256.0f, projectMatrix); // ������ ������ 0
            Matrix4f.translate(0.0F, 0.0F, -64.0F, projectMatrix, projectMatrix);
            projectMatrix.store(projectMatrixMoss);
            unsafe { GL11.glLoadMatrixf((float*)Mem.getArrayTempAddress(projectMatrixMoss)); }
        }

        public void traceRay(float cameraX, float cameraY, float cameraZ, float xRot, float yRot) {
            float dirX = (float)System.Math.Cos(xRot) * (float)System.Math.Sin(yRot);
            float dirY = (float)-System.Math.Sin(xRot);
            float dirZ = (float)-System.Math.Cos(yRot) * (float)System.Math.Cos(xRot);

            //float length = dirX * dirX + dirY * dirY + dirZ * dirZ;
            //if (length < 0.01F)
            //    return;
            // Нормализация вектора необходима если нет ограничения от -pi*2 до +pi*2 текущим кодовом решении есть ограничение с.м. класс Entity метод turn
            //length = (float)System.Math.Sqrt(length);
            //dirX /= length;
            //dirY /= length;
            //dirZ /= length;

            float currentX = cameraX;
            float currentY = cameraY;
            float currentZ = cameraZ;
            float stepSize = 0.2F; // 1.0F
            int maxSteps = 50;
            hitResult.s = false;
            for (int i = 0; i < maxSteps; i += 1) {
                currentX += dirX * stepSize;
                currentY += dirY * stepSize;
                currentZ += dirZ * stepSize;
                float dx = currentX - cameraX;
                float dy = currentY - cameraY;
                float dz = currentZ - cameraZ;
                float endL = dx * dx + dy * dy + dz * dz;
                if (endL > 36)
                    break;
                if (level.isTile((int)currentX, (int)currentY, (int)currentZ)) {
                    hitResult.x = (int)currentX;
                    hitResult.y = (int)currentY;
                    hitResult.z = (int)currentZ;
                    hitResult.s = true;
                    break;
                }
                hitResult.xo = (int)currentX;
                hitResult.yo = (int)currentY;
                hitResult.zo = (int)currentZ;
            }
        }

        public void drawSelectionBox(Tessellator tessellator, HitResult hitResult) {
            GL11.glEnable(3042);
            GL11.glBlendFunc(770, 771);
            GL11.glLineWidth(2.0f);
            GL11.glDisable(3553);
            GL11.glDepthMask(GL11.GL_FALSE);
            tessellator.color(0.0f, 0.0f, 0.0f, 0.4f);
            tessellator.clear(); tessellator.mode = 3; tessellator.hasColor = true; // 3
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y - 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y - 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y - 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y - 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y - 0.002f, hitResult.z - 0.002f);
            tessellator.flush();
            tessellator.clear(); tessellator.mode = 3; tessellator.hasColor = true; // 3
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y + 1 + 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y + 1 + 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y + 1 + 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y + 1 + 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y + 1 + 0.002f, hitResult.z - 0.002f);
            tessellator.flush();
            tessellator.clear(); tessellator.mode = 1; tessellator.hasColor = true; //1
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y - 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y + 1 + 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y - 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y + 1 + 0.002f, hitResult.z - 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y - 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x + 1 + 0.002f, hitResult.y + 1 + 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y - 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.vertex(hitResult.x - 0.002f, hitResult.y + 1 + 0.002f, hitResult.z + 1 + 0.002f);
            tessellator.flush();
            GL11.glDepthMask(GL11.GL_TRUE);
            GL11.glEnable(3553);
            GL11.glDisable(3042);
        }

        public float renderCharsShadow(Font font, string chars, float posX, float posY, float posZ, uint color) {
            float result = 0;
            int length = chars.Length;
            char ch = (char)0x00;
            float posXSet = posX;
            float posYSet = posY;
            for (int i = 0; i < length; i++) {
                ch = chars[i];
                if (ch == '\n') {
                    posYSet += font.heightSymbolAtlas * font.fontSize;
                    posXSet = posX;
                    continue; // надо!
                }
                if (ch == ' ') {
                    posXSet += (font.getSymbolWidth(ch) / 3) * font.fontSize;
                    continue; // надо!
                }
                font.tessellator.color((color & 0xFF000000) | (color & 0xFCFCFC) >> 2);
                font.renderChar(chars[i], posXSet + result + font.fontSize, posYSet + font.fontSize, posZ - 0.01f);
                font.tessellator.color(font.colorHex);
                result += font.renderChar(chars[i], posXSet + result, posYSet, posZ);
            }
            return result;
        }

        public override unsafe void main(string[] args) {
            //Sys.initialize();
            Display wind = new Display();
            wind.setTitle("Game CubeTest");
            GL.initGL();
            void* glcontext = GLContext.createContext(wind);
            wind.show();

            System.Console.WriteLine(System.Environment.CurrentDirectory);
            uint tex = Textures.loadTexture(".\\texture.png", GL11.GL_NEAREST);
            GL11.glEnable(GL11.GL_TEXTURE_2D);
            GL11.glBindTexture(GL11.GL_TEXTURE_2D, tex);

            GL11.glMatrixMode(GL11.GL_PROJECTION);
            GL11.glLoadIdentity();

            GL11.glMatrixMode(GL11.GL_MODELVIEW);
            GL11.glLoadIdentity();

            GL11.glClearDepth(1.0F);
            GL11.glEnable(GL11.GL_DEPTH_TEST);
            GL11.glDepthFunc(GL11.GL_LEQUAL);
            GL11.glDepthMask(GL11.GL_TRUE);
            GL11.glEnable(GL11.GL_ALPHA_TEST);
            GL11.glAlphaFunc(GL11.GL_GREATER, 0.0F);

            GL11.glEnable(GL11.GL_CULL_FACE); // Включить отсечение обратных граней
            GL11.glCullFace(GL11.GL_BACK); // Отсекать задние грани

            GL11.glEnable(3553); // GL_TEXTURE_2D
            GL11.glShadeModel(7425);//glShadeModel(GL_SMOOTH);

            level = new Level(48, 48, 48);
            entity = new Entity(level);
            hitResult = new HitResult();
            entity.setPosition(16, 20, 16);
            entity.resetPosition();

            try {
                byte[] temp = System.IO.File.ReadAllBytes("level.dat");
                for (int i = 0; i < level.blocks.Length; i += 1) {
                    level.blocks[i] = temp[i];
                }
            }
            catch (System.Exception ex) {
                level.generateTiles();
            }
            //level.generateCaves();
            level.generateChunks();

            ParticleEngine particleEngine = new ParticleEngine(level);

            Tessellator tessellator = new Tessellator(48 * 2);
            tessellator.mode = GL11.GL_QUADS;
            
            Font font = new Font();
            font.fileFormat = "./font/unicode_page_{0:x2}.png";
            font.fileWidth = "./font/size_width.bin";
            font.fileHeight = "./font/size_height.bin";
            font.fontSize = 1.0F;
            font.italicF = 0.0F;
            font.load();
            font.setColorHex(0xffffffff);

            scaledResolution = new ScaledResolution();
            scaledResolution.calculateScale(1, wind.width, wind.height, true);

            float xa = 0.0F;
            float za = 0.0F;
            Timer timer = new Timer(20);
            bool changePolygonMode = false;
            float leftClickDelayTimer = 0; // delayClick
            float rightClickDelayTimer = 0; // delayClick
            byte type = 1;
            while (!wind.isCloseRequested) {
                //xRot += 0.001f;
                GL11.glClear(16640);
                GL11.glViewport(0, 0, wind.width, wind.height);

                GL11.glBindTexture(GL11.GL_TEXTURE_2D, tex);

                setupCamera(timer.fractionalTicks, wind.width, wind.height);
                if (wind.isGrabbedMouse) {
                    entity.turn(wind.xDeltaMouse, -wind.yDeltaMouse);
                    wind.xDeltaMouse = wind.yDeltaMouse = 0;
                }
                level.draw(entity.x, entity.y, entity.z);

                traceRay(xDeltaPos, yDeltaPos, zDeltaPos, entity.xRot, entity.yRot);
                tessellator.clear();
                tessellator.mode = GL11.GL_QUADS;
                if (hitResult.s) {
                    GL11.glDisable(GL11.GL_TEXTURE_2D);
                    tessellator.color(0.1f, 0.1f, 0.1f, 1f);
                    drawSelectionBox(tessellator, hitResult);
                    GL11.glEnable(GL11.GL_TEXTURE_2D);
                }
                tessellator.flush();

                GL11.glDisable(GL11.GL_CULL_FACE); // отсечение обратных граней
                tessellator.mode = GL11.GL_QUADS;
                particleEngine.render(entity, tessellator, timer.fractionalTicks, 0);
                GL11.glEnable(GL11.GL_CULL_FACE); // отсечение обратных граней

                timer.update();
                for (int ticks = 0; ticks < timer.ticks; ticks += 1) {
                    if (wind.isKeyPressed(KeycodeEx.VK_TAB))
                        wind.setGrabbedCursor(!wind.isGrabbedMouse);

                    if (wind.isKeyPressed(KeycodeEx.VK_ESCAPE))
                        wind.isCloseRequested = true;
                    xa = 0.0F;
                    za = 0.0F;
                    if (wind.isKeyDown(87))
                        za--;
                    if (wind.isKeyDown(83))
                        za++;
                    if (wind.isKeyDown(65))
                        xa--;
                    if (wind.isKeyDown(68))
                        xa++;
                    if (wind.isKeyDown(32)) {
                        if (entity.onGround && !entity.onFly) {
                            entity.yd = 0.35F;
                        }
                        if (entity.onFly)
                            entity.yd += 0.1F;
                    }
                    if (wind.isKeyDown(16)) {
                        if (entity.onFly)
                            entity.yd -= 0.1F;
                        else
                            entity.isSneaking = true;
                    }
                    else {
                        entity.isSneaking = false;
                    }

                    if (wind.isKeyDown(KeycodeEx.VK_R))
                        entity.resetPosition();

                    if (wind.isKeyPressed(KeycodeEx.VK_F))
                        entity.onFly = !entity.onFly;

                    if (wind.isKeyPressed(KeycodeEx.VK_V)) {
                        changePolygonMode = !changePolygonMode;
                        if (changePolygonMode)
                            GL11.glPolygonMode(1032, 6913);
                        else
                            GL11.glPolygonMode(1032, 6914);
                    }

                    if (wind.isKeyPressed(KeycodeEx.VK_G)) {
                        level.generateTiles();
                        level.updateChunks();
                    }

                    if (leftClickDelayTimer > 0) {
                        --leftClickDelayTimer;
                    }

                    if (rightClickDelayTimer > 0) {
                        --rightClickDelayTimer;
                    }

                    if (wind.isMouseKeyDown(0) && hitResult.s && rightClickDelayTimer == 0) {
                        byte var0 = level.getTile(hitResult.x, hitResult.y, hitResult.z);
                        level.setTileAt(hitResult.x, hitResult.y, hitResult.z, 0);
                        rightClickDelayTimer = 4;
                        
                        for (int i = -1; i < 2; i++) {
                            for (int j = -1; j < 2; j++) {
                                for (int n = -1; n < 2; n++) {
                                    Particle var1 = new Particle(level, hitResult.x + 0.5F, hitResult.y + 0.5F, hitResult.z + 0.5F, i, j, n, var0 - 1);
                                    particleEngine.add(var1);
                                }
                            }
                        }
                    }

                    if (wind.isMouseKeyDown(1) && hitResult.s && rightClickDelayTimer == 0) {
                        // Нельзя поставить блок в себя!!!
                        AABB blockBB = new AABB(hitResult.xo, hitResult.yo, hitResult.zo, hitResult.xo + 1, hitResult.yo + 1, hitResult.zo + 1);
                        if (!this.entity.boundingBox.intersects(blockBB)) {
                            level.setTileAt(hitResult.xo, hitResult.yo, hitResult.zo, type);
                            rightClickDelayTimer = 4;
                        }
                    }

                    if (wind.zMouse > 0) {
                        wind.zMouse = 0;
                        if (type < 4)
                            type += 1;
                    }

                    if (wind.zMouse < 0) {
                        wind.zMouse = 0;
                        if (type > 1)
                            type -= 1;
                    }

                    if (wind.isKeyPressed(KeycodeEx.VK_LEFT))
                        entity.yRot -= 0.01f;
                    if (wind.isKeyPressed(KeycodeEx.VK_RIGHT))
                        entity.yRot += 0.01f;

                    if (wind.isKeyPressed(KeycodeEx.VK_UP))
                        entity.xRot -= 0.01f;
                    if (wind.isKeyPressed(KeycodeEx.VK_DOWN))
                        entity.xRot += 0.01f;

                    if (wind.isKeyPressed(KeycodeEx.VK_F12))
                        wind.setFullscreen(!wind.isFullscreen);

                    entity.moveRelativeV(xa, za);
                    entity.tick();
                    particleEngine.tick();
                }

                scaledResolution.calculateScale(1, wind.width, wind.height, true);
                setupCameraGui();
                GL11.glEnable(GL11.GL_TEXTURE_2D);
                renderCharsShadow(font, string.Format("fps/DT {0} / {1}", timer.framesPerSecond, timer.fractionalTicks), 4, 4, 0, 0xffffffff); // DT Delta Time
                renderCharsShadow(font, string.Format("x,y,z {0}, {1}, {2}", entity.x, entity.y, entity.z), 4, 16 + 4, 0, 0xffffffff);
                renderCharsShadow(font, string.Format("xRot,yRot {0}, {1}", entity.xRot, entity.yRot), 4, 32 + 4, 0, 0xffffffff);
                
                GL11.glDisable(GL11.GL_TEXTURE_2D);
                float wc = wind.width / 2;
                float hc = wind.height / 2;
                tessellator.clear();
                tessellator.mode = GL11.GL_QUADS;
                tessellator.vertex((wc + 2), (hc - 7), 0.0F);
                tessellator.vertex((wc - 0), (hc - 7), 0.0F);
                tessellator.vertex((wc - 0), (hc + 9), 0.0F);
                tessellator.vertex((wc + 2), (hc + 9), 0.0F);

                tessellator.vertex((wc + 9), (hc - 0), 0.0F);
                tessellator.vertex((wc - 7), (hc - 0), 0.0F);
                tessellator.vertex((wc - 7), (hc + 2), 0.0F);
                tessellator.vertex((wc + 9), (hc + 2), 0.0F);
                tessellator.flush();
                GL11.glEnable(GL11.GL_TEXTURE_2D);

                GLContext.update(wind);
                wind.update();
                if (timer.elapsedNanoseconds > 0)
                    System.Threading.Thread.Sleep((int)(60000000L / timer.elapsedNanoseconds)); //Convert ns to ms and sleep 1000000
            }
            GLContext.destroyContext(wind, glcontext);
            wind.destroy();
            System.IO.File.WriteAllBytes("level.dat", level.blocks);
        }
    }
}
