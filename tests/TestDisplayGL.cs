//======================================
//  TestDisplayGL
//  Created on: 20.01.2026 23:36:30
//  Author: Vova43
//======================================
namespace tests {
    public class TestDisplayGL : Test {
        private float fovyRadians = (float)System.Math.Tan(70 * 0.5 * 3.1415F / 180); // 70 / 2 * 3.1415F / 180;
        private float xRot = 0, yRot = 0;
        public override unsafe void main(string[] args) {
            platform.Display display = new platform.Display(true);
            openGL.GL.initGL();

            phys.vector.Matrix4f projectMatrix = new phys.vector.Matrix4f();
            float[] projectMatrixMoss = new float[16];

            openGL.GL11.glMatrixMode(openGL.GL11.GL_PROJECTION);
            openGL.GL11.glLoadIdentity();
            void* glcontext = openGL.GLContext.createContext(display);
            while (!display.isCloseRequested) {
                projectMatrix.setIdentity();
                phys.vector.MatrixUtils.projection(fovyRadians, (float)display.width / display.height, 0.05F, 250.0F, projectMatrix);
                phys.vector.Matrix4f.translate(-0, -0, -0.03F, projectMatrix, projectMatrix);
                phys.vector.Matrix4f.rotate(xRot, 1.0f, 0.0f, 0.0f, projectMatrix, projectMatrix);
                phys.vector.Matrix4f.rotate(yRot, 0.0f, 1.0f, 0.0f, projectMatrix, projectMatrix);
                phys.vector.Matrix4f.rotate(0, 0, 0, 1.0f, projectMatrix, projectMatrix);
                phys.vector.Matrix4f.translate(-0, -0, -3F, projectMatrix, projectMatrix);
                
                projectMatrix.store(projectMatrixMoss);
                unsafe { openGL.GL11.glLoadMatrixf((float*)platform.Mem.getArrayTempAddress(projectMatrixMoss)); }

                openGL.GL11.glViewport(0, 0, display.width, display.height);
                openGL.GL11.glClear(16640); // 16640 => GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT
                openGL.GL11.glBegin(openGL.GL11.GL_TRIANGLES);
                openGL.GL11.glVertex3f(0, 0, 0);
                openGL.GL11.glVertex3f(1, 0, 0);
                openGL.GL11.glVertex3f(1, 1, 0);
                openGL.GL11.glEnd();
                openGL.GL11.glFlush();
                openGL.GLContext.update(display);
                display.update();
                if (display.keys[platform.KeycodeEx.VK_ESCAPE])
                    display.isCloseRequested = true;
            }
            openGL.GLContext.destroyContext(display, glcontext);
            display.destroy();
            //System.Console.ReadKey();
        }
    }
}
