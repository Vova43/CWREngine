// by Vova43 / vova436612 ‎9.09.‎2024 ‏‎15:46:33 - 03.10.2025 15:46:00
namespace openGL {
    public static unsafe class GL11 {
        #region OpenGL 1.1 constants
        public const System.Int32 GL_ACCUM = 256;
        public const System.Int32 GL_LOAD = 257;
        public const System.Int32 GL_RETURN = 258;
        public const System.Int32 GL_MULT = 259;
        public const System.Int32 GL_ADD = 260;
        public const System.Int32 GL_NEVER = 512;
        public const System.Int32 GL_LESS = 513;
        public const System.Int32 GL_EQUAL = 514;
        public const System.Int32 GL_LEQUAL = 515;
        public const System.Int32 GL_GREATER = 516;
        public const System.Int32 GL_NOTEQUAL = 517;
        public const System.Int32 GL_GEQUAL = 518;
        public const System.Int32 GL_ALWAYS = 519;
        public const System.Int32 GL_CURRENT_BIT = 1;
        public const System.Int32 GL_POINT_BIT = 2;
        public const System.Int32 GL_LINE_BIT = 4;
        public const System.Int32 GL_POLYGON_BIT = 8;
        public const System.Int32 GL_POLYGON_STIPPLE_BIT = 16;
        public const System.Int32 GL_PIXEL_MODE_BIT = 32;
        public const System.Int32 GL_LIGHTING_BIT = 64;
        public const System.Int32 GL_FOG_BIT = 128;
        public const System.Int32 GL_DEPTH_BUFFER_BIT = 256;
        public const System.Int32 GL_ACCUM_BUFFER_BIT = 512;
        public const System.Int32 GL_STENCIL_BUFFER_BIT = 1024;
        public const System.Int32 GL_VIEWPORT_BIT = 2048;
        public const System.Int32 GL_TRANSFORM_BIT = 4096;
        public const System.Int32 GL_ENABLE_BIT = 8192;
        public const System.Int32 GL_COLOR_BUFFER_BIT = 16384;
        public const System.Int32 GL_HINT_BIT = 32768;
        public const System.Int32 GL_EVAL_BIT = 65536;
        public const System.Int32 GL_LIST_BIT = 131072;
        public const System.Int32 GL_TEXTURE_BIT = 262144;
        public const System.Int32 GL_SCISSOR_BIT = 524288;
        public const System.Int32 GL_ALL_ATTRIB_BITS = 1048575;
        public const System.Int32 GL_POINTS = 0;
        public const System.Int32 GL_LINES = 1;
        public const System.Int32 GL_LINE_LOOP = 2;
        public const System.Int32 GL_LINE_STRIP = 3;
        public const System.Int32 GL_TRIANGLES = 4;
        public const System.Int32 GL_TRIANGLE_STRIP = 5;
        public const System.Int32 GL_TRIANGLE_FAN = 6;
        public const System.Int32 GL_QUADS = 7;
        public const System.Int32 GL_QUAD_STRIP = 8;
        public const System.Int32 GL_POLYGON = 9;
        public const System.Int32 GL_ZERO = 0;
        public const System.Int32 GL_ONE = 1;
        public const System.Int32 GL_SRC_COLOR = 768;
        public const System.Int32 GL_ONE_MINUS_SRC_COLOR = 769;
        public const System.Int32 GL_SRC_ALPHA = 770;
        public const System.Int32 GL_ONE_MINUS_SRC_ALPHA = 771;
        public const System.Int32 GL_DST_ALPHA = 772;
        public const System.Int32 GL_ONE_MINUS_DST_ALPHA = 773;
        public const System.Int32 GL_DST_COLOR = 774;
        public const System.Int32 GL_ONE_MINUS_DST_COLOR = 775;
        public const System.Int32 GL_SRC_ALPHA_SATURATE = 776;
        public const System.Int32 GL_CONSTANT_COLOR = 32769;
        public const System.Int32 GL_ONE_MINUS_CONSTANT_COLOR = 32770;
        public const System.Int32 GL_CONSTANT_ALPHA = 32771;
        public const System.Int32 GL_ONE_MINUS_CONSTANT_ALPHA = 32772;
        public const System.Int32 GL_TRUE = 1;
        public const System.Int32 GL_FALSE = 0;
        public const System.Int32 GL_CLIP_PLANE0 = 12288;
        public const System.Int32 GL_CLIP_PLANE1 = 12289;
        public const System.Int32 GL_CLIP_PLANE2 = 12290;
        public const System.Int32 GL_CLIP_PLANE3 = 12291;
        public const System.Int32 GL_CLIP_PLANE4 = 12292;
        public const System.Int32 GL_CLIP_PLANE5 = 12293;
        public const System.Int32 GL_BYTE = 5120;
        public const System.Int32 GL_UNSIGNED_BYTE = 5121;
        public const System.Int32 GL_SHORT = 5122;
        public const System.Int32 GL_UNSIGNED_SHORT = 5123;
        public const System.Int32 GL_INT = 5124;
        public const System.Int32 GL_UNSIGNED_INT = 5125;
        public const System.Int32 GL_FLOAT = 5126;
        public const System.Int32 GL_2_BYTES = 5127;
        public const System.Int32 GL_3_BYTES = 5128;
        public const System.Int32 GL_4_BYTES = 5129;
        public const System.Int32 GL_DOUBLE = 5130;
        public const System.Int32 GL_NONE = 0;
        public const System.Int32 GL_FRONT_LEFT = 1024;
        public const System.Int32 GL_FRONT_RIGHT = 1025;
        public const System.Int32 GL_BACK_LEFT = 1026;
        public const System.Int32 GL_BACK_RIGHT = 1027;
        public const System.Int32 GL_FRONT = 1028;
        public const System.Int32 GL_BACK = 1029;
        public const System.Int32 GL_LEFT = 1030;
        public const System.Int32 GL_RIGHT = 1031;
        public const System.Int32 GL_FRONT_AND_BACK = 1032;
        public const System.Int32 GL_AUX0 = 1033;
        public const System.Int32 GL_AUX1 = 1034;
        public const System.Int32 GL_AUX2 = 1035;
        public const System.Int32 GL_AUX3 = 1036;
        public const System.Int32 GL_NO_ERROR = 0;
        public const System.Int32 GL_INVALID_ENUM = 1280;
        public const System.Int32 GL_INVALID_VALUE = 1281;
        public const System.Int32 GL_INVALID_OPERATION = 1282;
        public const System.Int32 GL_STACK_OVERFLOW = 1283;
        public const System.Int32 GL_STACK_UNDERFLOW = 1284;
        public const System.Int32 GL_OUT_OF_MEMORY = 1285;
        public const System.Int32 GL_2D = 1536;
        public const System.Int32 GL_3D = 1537;
        public const System.Int32 GL_3D_COLOR = 1538;
        public const System.Int32 GL_3D_COLOR_TEXTURE = 1539;
        public const System.Int32 GL_4D_COLOR_TEXTURE = 1540;
        public const System.Int32 GL_PASS_THROUGH_TOKEN = 1792;
        public const System.Int32 GL_POINT_TOKEN = 1793;
        public const System.Int32 GL_LINE_TOKEN = 1794;
        public const System.Int32 GL_POLYGON_TOKEN = 1795;
        public const System.Int32 GL_BITMAP_TOKEN = 1796;
        public const System.Int32 GL_DRAW_PIXEL_TOKEN = 1797;
        public const System.Int32 GL_COPY_PIXEL_TOKEN = 1798;
        public const System.Int32 GL_LINE_RESET_TOKEN = 1799;
        public const System.Int32 GL_EXP = 2048;
        public const System.Int32 GL_EXP2 = 2049;
        public const System.Int32 GL_CW = 2304;
        public const System.Int32 GL_CCW = 2305;
        public const System.Int32 GL_COEFF = 2560;
        public const System.Int32 GL_ORDER = 2561;
        public const System.Int32 GL_DOMAIN = 2562;
        public const System.Int32 GL_CURRENT_COLOR = 2816;
        public const System.Int32 GL_CURRENT_INDEX = 2817;
        public const System.Int32 GL_CURRENT_NORMAL = 2818;
        public const System.Int32 GL_CURRENT_TEXTURE_COORDS = 2819;
        public const System.Int32 GL_CURRENT_RASTER_COLOR = 2820;
        public const System.Int32 GL_CURRENT_RASTER_INDEX = 2821;
        public const System.Int32 GL_CURRENT_RASTER_TEXTURE_COORDS = 2822;
        public const System.Int32 GL_CURRENT_RASTER_POSITION = 2823;
        public const System.Int32 GL_CURRENT_RASTER_POSITION_VALID = 2824;
        public const System.Int32 GL_CURRENT_RASTER_DISTANCE = 2825;
        public const System.Int32 GL_POINT_SMOOTH = 2832;
        public const System.Int32 GL_POINT_SIZE = 2833;
        public const System.Int32 GL_POINT_SIZE_RANGE = 2834;
        public const System.Int32 GL_POINT_SIZE_GRANULARITY = 2835;
        public const System.Int32 GL_LINE_SMOOTH = 2848;
        public const System.Int32 GL_LINE_WIDTH = 2849;
        public const System.Int32 GL_LINE_WIDTH_RANGE = 2850;
        public const System.Int32 GL_LINE_WIDTH_GRANULARITY = 2851;
        public const System.Int32 GL_LINE_STIPPLE = 2852;
        public const System.Int32 GL_LINE_STIPPLE_PATTERN = 2853;
        public const System.Int32 GL_LINE_STIPPLE_REPEAT = 2854;
        public const System.Int32 GL_LIST_MODE = 2864;
        public const System.Int32 GL_MAX_LIST_NESTING = 2865;
        public const System.Int32 GL_LIST_BASE = 2866;
        public const System.Int32 GL_LIST_INDEX = 2867;
        public const System.Int32 GL_POLYGON_MODE = 2880;
        public const System.Int32 GL_POLYGON_SMOOTH = 2881;
        public const System.Int32 GL_POLYGON_STIPPLE = 2882;
        public const System.Int32 GL_EDGE_FLAG = 2883;
        public const System.Int32 GL_CULL_FACE = 2884;
        public const System.Int32 GL_CULL_FACE_MODE = 2885;
        public const System.Int32 GL_FRONT_FACE = 2886;
        public const System.Int32 GL_LIGHTING = 2896;
        public const System.Int32 GL_LIGHT_MODEL_LOCAL_VIEWER = 2897;
        public const System.Int32 GL_LIGHT_MODEL_TWO_SIDE = 2898;
        public const System.Int32 GL_LIGHT_MODEL_AMBIENT = 2899;
        public const System.Int32 GL_SHADE_MODEL = 2900;
        public const System.Int32 GL_COLOR_MATERIAL_FACE = 2901;
        public const System.Int32 GL_COLOR_MATERIAL_PARAMETER = 2902;
        public const System.Int32 GL_COLOR_MATERIAL = 2903;
        public const System.Int32 GL_FOG = 2912;
        public const System.Int32 GL_FOG_INDEX = 2913;
        public const System.Int32 GL_FOG_DENSITY = 2914;
        public const System.Int32 GL_FOG_START = 2915;
        public const System.Int32 GL_FOG_END = 2916;
        public const System.Int32 GL_FOG_MODE = 2917;
        public const System.Int32 GL_FOG_COLOR = 2918;
        public const System.Int32 GL_DEPTH_RANGE = 2928;
        public const System.Int32 GL_DEPTH_TEST = 2929;
        public const System.Int32 GL_DEPTH_WRITEMASK = 2930;
        public const System.Int32 GL_DEPTH_CLEAR_VALUE = 2931;
        public const System.Int32 GL_DEPTH_FUNC = 2932;
        public const System.Int32 GL_ACCUM_CLEAR_VALUE = 2944;
        public const System.Int32 GL_STENCIL_TEST = 2960;
        public const System.Int32 GL_STENCIL_CLEAR_VALUE = 2961;
        public const System.Int32 GL_STENCIL_FUNC = 2962;
        public const System.Int32 GL_STENCIL_VALUE_MASK = 2963;
        public const System.Int32 GL_STENCIL_FAIL = 2964;
        public const System.Int32 GL_STENCIL_PASS_DEPTH_FAIL = 2965;
        public const System.Int32 GL_STENCIL_PASS_DEPTH_PASS = 2966;
        public const System.Int32 GL_STENCIL_REF = 2967;
        public const System.Int32 GL_STENCIL_WRITEMASK = 2968;
        public const System.Int32 GL_MATRIX_MODE = 2976;
        public const System.Int32 GL_NORMALIZE = 2977;
        public const System.Int32 GL_VIEWPORT = 2978;
        public const System.Int32 GL_MODELVIEW_STACK_DEPTH = 2979;
        public const System.Int32 GL_PROJECTION_STACK_DEPTH = 2980;
        public const System.Int32 GL_TEXTURE_STACK_DEPTH = 2981;
        public const System.Int32 GL_MODELVIEW_MATRIX = 2982;
        public const System.Int32 GL_PROJECTION_MATRIX = 2983;
        public const System.Int32 GL_TEXTURE_MATRIX = 2984;
        public const System.Int32 GL_ATTRIB_STACK_DEPTH = 2992;
        public const System.Int32 GL_CLIENT_ATTRIB_STACK_DEPTH = 2993;
        public const System.Int32 GL_ALPHA_TEST = 3008;
        public const System.Int32 GL_ALPHA_TEST_FUNC = 3009;
        public const System.Int32 GL_ALPHA_TEST_REF = 3010;
        public const System.Int32 GL_DITHER = 3024;
        public const System.Int32 GL_BLEND_DST = 3040;
        public const System.Int32 GL_BLEND_SRC = 3041;
        public const System.Int32 GL_BLEND = 3042;
        public const System.Int32 GL_LOGIC_OP_MODE = 3056;
        public const System.Int32 GL_INDEX_LOGIC_OP = 3057;
        public const System.Int32 GL_COLOR_LOGIC_OP = 3058;
        public const System.Int32 GL_AUX_BUFFERS = 3072;
        public const System.Int32 GL_DRAW_BUFFER = 3073;
        public const System.Int32 GL_READ_BUFFER = 3074;
        public const System.Int32 GL_SCISSOR_BOX = 3088;
        public const System.Int32 GL_SCISSOR_TEST = 3089;
        public const System.Int32 GL_INDEX_CLEAR_VALUE = 3104;
        public const System.Int32 GL_INDEX_WRITEMASK = 3105;
        public const System.Int32 GL_COLOR_CLEAR_VALUE = 3106;
        public const System.Int32 GL_COLOR_WRITEMASK = 3107;
        public const System.Int32 GL_INDEX_MODE = 3120;
        public const System.Int32 GL_RGBA_MODE = 3121;
        public const System.Int32 GL_DOUBLEBUFFER = 3122;
        public const System.Int32 GL_STEREO = 3123;
        public const System.Int32 GL_RENDER_MODE = 3136;
        public const System.Int32 GL_PERSPECTIVE_CORRECTION_HINT = 3152;
        public const System.Int32 GL_POINT_SMOOTH_HINT = 3153;
        public const System.Int32 GL_LINE_SMOOTH_HINT = 3154;
        public const System.Int32 GL_POLYGON_SMOOTH_HINT = 3155;
        public const System.Int32 GL_FOG_HINT = 3156;
        public const System.Int32 GL_TEXTURE_GEN_S = 3168;
        public const System.Int32 GL_TEXTURE_GEN_T = 3169;
        public const System.Int32 GL_TEXTURE_GEN_R = 3170;
        public const System.Int32 GL_TEXTURE_GEN_Q = 3171;
        public const System.Int32 GL_PIXEL_MAP_I_TO_I = 3184;
        public const System.Int32 GL_PIXEL_MAP_S_TO_S = 3185;
        public const System.Int32 GL_PIXEL_MAP_I_TO_R = 3186;
        public const System.Int32 GL_PIXEL_MAP_I_TO_G = 3187;
        public const System.Int32 GL_PIXEL_MAP_I_TO_B = 3188;
        public const System.Int32 GL_PIXEL_MAP_I_TO_A = 3189;
        public const System.Int32 GL_PIXEL_MAP_R_TO_R = 3190;
        public const System.Int32 GL_PIXEL_MAP_G_TO_G = 3191;
        public const System.Int32 GL_PIXEL_MAP_B_TO_B = 3192;
        public const System.Int32 GL_PIXEL_MAP_A_TO_A = 3193;
        public const System.Int32 GL_PIXEL_MAP_I_TO_I_SIZE = 3248;
        public const System.Int32 GL_PIXEL_MAP_S_TO_S_SIZE = 3249;
        public const System.Int32 GL_PIXEL_MAP_I_TO_R_SIZE = 3250;
        public const System.Int32 GL_PIXEL_MAP_I_TO_G_SIZE = 3251;
        public const System.Int32 GL_PIXEL_MAP_I_TO_B_SIZE = 3252;
        public const System.Int32 GL_PIXEL_MAP_I_TO_A_SIZE = 3253;
        public const System.Int32 GL_PIXEL_MAP_R_TO_R_SIZE = 3254;
        public const System.Int32 GL_PIXEL_MAP_G_TO_G_SIZE = 3255;
        public const System.Int32 GL_PIXEL_MAP_B_TO_B_SIZE = 3256;
        public const System.Int32 GL_PIXEL_MAP_A_TO_A_SIZE = 3257;
        public const System.Int32 GL_UNPACK_SWAP_BYTES = 3312;
        public const System.Int32 GL_UNPACK_LSB_FIRST = 3313;
        public const System.Int32 GL_UNPACK_ROW_LENGTH = 3314;
        public const System.Int32 GL_UNPACK_SKIP_ROWS = 3315;
        public const System.Int32 GL_UNPACK_SKIP_PIXELS = 3316;
        public const System.Int32 GL_UNPACK_ALIGNMENT = 3317;
        public const System.Int32 GL_PACK_SWAP_BYTES = 3328;
        public const System.Int32 GL_PACK_LSB_FIRST = 3329;
        public const System.Int32 GL_PACK_ROW_LENGTH = 3330;
        public const System.Int32 GL_PACK_SKIP_ROWS = 3331;
        public const System.Int32 GL_PACK_SKIP_PIXELS = 3332;
        public const System.Int32 GL_PACK_ALIGNMENT = 3333;
        public const System.Int32 GL_MAP_COLOR = 3344;
        public const System.Int32 GL_MAP_STENCIL = 3345;
        public const System.Int32 GL_INDEX_SHIFT = 3346;
        public const System.Int32 GL_INDEX_OFFSET = 3347;
        public const System.Int32 GL_RED_SCALE = 3348;
        public const System.Int32 GL_RED_BIAS = 3349;
        public const System.Int32 GL_ZOOM_X = 3350;
        public const System.Int32 GL_ZOOM_Y = 3351;
        public const System.Int32 GL_GREEN_SCALE = 3352;
        public const System.Int32 GL_GREEN_BIAS = 3353;
        public const System.Int32 GL_BLUE_SCALE = 3354;
        public const System.Int32 GL_BLUE_BIAS = 3355;
        public const System.Int32 GL_ALPHA_SCALE = 3356;
        public const System.Int32 GL_ALPHA_BIAS = 3357;
        public const System.Int32 GL_DEPTH_SCALE = 3358;
        public const System.Int32 GL_DEPTH_BIAS = 3359;
        public const System.Int32 GL_MAX_EVAL_ORDER = 3376;
        public const System.Int32 GL_MAX_LIGHTS = 3377;
        public const System.Int32 GL_MAX_CLIP_PLANES = 3378;
        public const System.Int32 GL_MAX_TEXTURE_SIZE = 3379;
        public const System.Int32 GL_MAX_PIXEL_MAP_TABLE = 3380;
        public const System.Int32 GL_MAX_ATTRIB_STACK_DEPTH = 3381;
        public const System.Int32 GL_MAX_MODELVIEW_STACK_DEPTH = 3382;
        public const System.Int32 GL_MAX_NAME_STACK_DEPTH = 3383;
        public const System.Int32 GL_MAX_PROJECTION_STACK_DEPTH = 3384;
        public const System.Int32 GL_MAX_TEXTURE_STACK_DEPTH = 3385;
        public const System.Int32 GL_MAX_VIEWPORT_DIMS = 3386;
        public const System.Int32 GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 3387;
        public const System.Int32 GL_SUBPIXEL_BITS = 3408;
        public const System.Int32 GL_INDEX_BITS = 3409;
        public const System.Int32 GL_RED_BITS = 3410;
        public const System.Int32 GL_GREEN_BITS = 3411;
        public const System.Int32 GL_BLUE_BITS = 3412;
        public const System.Int32 GL_ALPHA_BITS = 3413;
        public const System.Int32 GL_DEPTH_BITS = 3414;
        public const System.Int32 GL_STENCIL_BITS = 3415;
        public const System.Int32 GL_ACCUM_RED_BITS = 3416;
        public const System.Int32 GL_ACCUM_GREEN_BITS = 3417;
        public const System.Int32 GL_ACCUM_BLUE_BITS = 3418;
        public const System.Int32 GL_ACCUM_ALPHA_BITS = 3419;
        public const System.Int32 GL_NAME_STACK_DEPTH = 3440;
        public const System.Int32 GL_AUTO_NORMAL = 3456;
        public const System.Int32 GL_MAP1_COLOR_4 = 3472;
        public const System.Int32 GL_MAP1_INDEX = 3473;
        public const System.Int32 GL_MAP1_NORMAL = 3474;
        public const System.Int32 GL_MAP1_TEXTURE_COORD_1 = 3475;
        public const System.Int32 GL_MAP1_TEXTURE_COORD_2 = 3476;
        public const System.Int32 GL_MAP1_TEXTURE_COORD_3 = 3477;
        public const System.Int32 GL_MAP1_TEXTURE_COORD_4 = 3478;
        public const System.Int32 GL_MAP1_VERTEX_3 = 3479;
        public const System.Int32 GL_MAP1_VERTEX_4 = 3480;
        public const System.Int32 GL_MAP2_COLOR_4 = 3504;
        public const System.Int32 GL_MAP2_INDEX = 3505;
        public const System.Int32 GL_MAP2_NORMAL = 3506;
        public const System.Int32 GL_MAP2_TEXTURE_COORD_1 = 3507;
        public const System.Int32 GL_MAP2_TEXTURE_COORD_2 = 3508;
        public const System.Int32 GL_MAP2_TEXTURE_COORD_3 = 3509;
        public const System.Int32 GL_MAP2_TEXTURE_COORD_4 = 3510;
        public const System.Int32 GL_MAP2_VERTEX_3 = 3511;
        public const System.Int32 GL_MAP2_VERTEX_4 = 3512;
        public const System.Int32 GL_MAP1_GRID_DOMAIN = 3536;
        public const System.Int32 GL_MAP1_GRID_SEGMENTS = 3537;
        public const System.Int32 GL_MAP2_GRID_DOMAIN = 3538;
        public const System.Int32 GL_MAP2_GRID_SEGMENTS = 3539;
        public const System.Int32 GL_TEXTURE_1D = 3552;
        public const System.Int32 GL_TEXTURE_2D = 3553;
        public const System.Int32 GL_FEEDBACK_BUFFER_POINTER = 3568;
        public const System.Int32 GL_FEEDBACK_BUFFER_SIZE = 3569;
        public const System.Int32 GL_FEEDBACK_BUFFER_TYPE = 3570;
        public const System.Int32 GL_SELECTION_BUFFER_POINTER = 3571;
        public const System.Int32 GL_SELECTION_BUFFER_SIZE = 3572;
        public const System.Int32 GL_TEXTURE_WIDTH = 4096;
        public const System.Int32 GL_TEXTURE_HEIGHT = 4097;
        public const System.Int32 GL_TEXTURE_INTERNAL_FORMAT = 4099;
        public const System.Int32 GL_TEXTURE_BORDER_COLOR = 4100;
        public const System.Int32 GL_TEXTURE_BORDER = 4101;
        public const System.Int32 GL_DONT_CARE = 4352;
        public const System.Int32 GL_FASTEST = 4353;
        public const System.Int32 GL_NICEST = 4354;
        public const System.Int32 GL_LIGHT0 = 16384;
        public const System.Int32 GL_LIGHT1 = 16385;
        public const System.Int32 GL_LIGHT2 = 16386;
        public const System.Int32 GL_LIGHT3 = 16387;
        public const System.Int32 GL_LIGHT4 = 16388;
        public const System.Int32 GL_LIGHT5 = 16389;
        public const System.Int32 GL_LIGHT6 = 16390;
        public const System.Int32 GL_LIGHT7 = 16391;
        public const System.Int32 GL_AMBIENT = 4608;
        public const System.Int32 GL_DIFFUSE = 4609;
        public const System.Int32 GL_SPECULAR = 4610;
        public const System.Int32 GL_POSITION = 4611;
        public const System.Int32 GL_SPOT_DIRECTION = 4612;
        public const System.Int32 GL_SPOT_EXPONENT = 4613;
        public const System.Int32 GL_SPOT_CUTOFF = 4614;
        public const System.Int32 GL_CONSTANT_ATTENUATION = 4615;
        public const System.Int32 GL_LINEAR_ATTENUATION = 4616;
        public const System.Int32 GL_QUADRATIC_ATTENUATION = 4617;
        public const System.Int32 GL_COMPILE = 4864;
        public const System.Int32 GL_COMPILE_AND_EXECUTE = 4865;
        public const System.Int32 GL_CLEAR = 5376;
        public const System.Int32 GL_AND = 5377;
        public const System.Int32 GL_AND_REVERSE = 5378;
        public const System.Int32 GL_COPY = 5379;
        public const System.Int32 GL_AND_INVERTED = 5380;
        public const System.Int32 GL_NOOP = 5381;
        public const System.Int32 GL_XOR = 5382;
        public const System.Int32 GL_OR = 5383;
        public const System.Int32 GL_NOR = 5384;
        public const System.Int32 GL_EQUIV = 5385;
        public const System.Int32 GL_INVERT = 5386;
        public const System.Int32 GL_OR_REVERSE = 5387;
        public const System.Int32 GL_COPY_INVERTED = 5388;
        public const System.Int32 GL_OR_INVERTED = 5389;
        public const System.Int32 GL_NAND = 5390;
        public const System.Int32 GL_SET = 5391;
        public const System.Int32 GL_EMISSION = 5632;
        public const System.Int32 GL_SHININESS = 5633;
        public const System.Int32 GL_AMBIENT_AND_DIFFUSE = 5634;
        public const System.Int32 GL_COLOR_INDEXES = 5635;
        public const System.Int32 GL_MODELVIEW = 5888;
        public const System.Int32 GL_PROJECTION = 5889;
        public const System.Int32 GL_TEXTURE = 5890;
        public const System.Int32 GL_COLOR = 6144;
        public const System.Int32 GL_DEPTH = 6145;
        public const System.Int32 GL_STENCIL = 6146;
        public const System.Int32 GL_COLOR_INDEX = 6400;
        public const System.Int32 GL_STENCIL_INDEX = 6401;
        public const System.Int32 GL_DEPTH_COMPONENT = 6402;
        public const System.Int32 GL_RED = 6403;
        public const System.Int32 GL_GREEN = 6404;
        public const System.Int32 GL_BLUE = 6405;
        public const System.Int32 GL_ALPHA = 6406;
        public const System.Int32 GL_RGB = 6407;
        public const System.Int32 GL_RGBA = 6408;
        public const System.Int32 GL_LUMINANCE = 6409;
        public const System.Int32 GL_LUMINANCE_ALPHA = 6410;
        public const System.Int32 GL_BITMAP = 6656;
        public const System.Int32 GL_POINT = 6912;
        public const System.Int32 GL_LINE = 6913;
        public const System.Int32 GL_FILL = 6914;
        public const System.Int32 GL_RENDER = 7168;
        public const System.Int32 GL_FEEDBACK = 7169;
        public const System.Int32 GL_SELECT = 7170;
        public const System.Int32 GL_FLAT = 7424;
        public const System.Int32 GL_SMOOTH = 7425;
        public const System.Int32 GL_KEEP = 7680;
        public const System.Int32 GL_REPLACE = 7681;
        public const System.Int32 GL_INCR = 7682;
        public const System.Int32 GL_DECR = 7683;
        public const System.Int32 GL_VENDOR = 7936;
        public const System.Int32 GL_RENDERER = 7937;
        public const System.Int32 GL_VERSION = 7938;
        public const System.Int32 GL_EXTENSIONS = 7939;
        public const System.Int32 GL_S = 8192;
        public const System.Int32 GL_T = 8193;
        public const System.Int32 GL_R = 8194;
        public const System.Int32 GL_Q = 8195;
        public const System.Int32 GL_MODULATE = 8448;
        public const System.Int32 GL_DECAL = 8449;
        public const System.Int32 GL_TEXTURE_ENV_MODE = 8704;
        public const System.Int32 GL_TEXTURE_ENV_COLOR = 8705;
        public const System.Int32 GL_TEXTURE_ENV = 8960;
        public const System.Int32 GL_EYE_LINEAR = 9216;
        public const System.Int32 GL_OBJECT_LINEAR = 9217;
        public const System.Int32 GL_SPHERE_MAP = 9218;
        public const System.Int32 GL_TEXTURE_GEN_MODE = 9472;
        public const System.Int32 GL_OBJECT_PLANE = 9473;
        public const System.Int32 GL_EYE_PLANE = 9474;
        public const System.Int32 GL_NEAREST = 9728;
        public const System.Int32 GL_LINEAR = 9729;
        public const System.Int32 GL_NEAREST_MIPMAP_NEAREST = 9984;
        public const System.Int32 GL_LINEAR_MIPMAP_NEAREST = 9985;
        public const System.Int32 GL_NEAREST_MIPMAP_LINEAR = 9986;
        public const System.Int32 GL_LINEAR_MIPMAP_LINEAR = 9987;
        public const System.Int32 GL_TEXTURE_MAG_FILTER = 10240;
        public const System.Int32 GL_TEXTURE_MIN_FILTER = 10241;
        public const System.Int32 GL_TEXTURE_WRAP_S = 10242;
        public const System.Int32 GL_TEXTURE_WRAP_T = 10243;
        public const System.Int32 GL_CLAMP = 10496;
        public const System.Int32 GL_REPEAT = 10497;
        public const System.Int32 GL_CLIENT_PIXEL_STORE_BIT = 1;
        public const System.Int32 GL_CLIENT_VERTEX_ARRAY_BIT = 2;
        public const System.Int32 GL_ALL_CLIENT_ATTRIB_BITS = -1;
        public const System.Int32 GL_POLYGON_OFFSET_FACTOR = 32824;
        public const System.Int32 GL_POLYGON_OFFSET_UNITS = 10752;
        public const System.Int32 GL_POLYGON_OFFSET_POINT = 10753;
        public const System.Int32 GL_POLYGON_OFFSET_LINE = 10754;
        public const System.Int32 GL_POLYGON_OFFSET_FILL = 32823;
        public const System.Int32 GL_ALPHA4 = 32827;
        public const System.Int32 GL_ALPHA8 = 32828;
        public const System.Int32 GL_ALPHA12 = 32829;
        public const System.Int32 GL_ALPHA16 = 32830;
        public const System.Int32 GL_LUMINANCE4 = 32831;
        public const System.Int32 GL_LUMINANCE8 = 32832;
        public const System.Int32 GL_LUMINANCE12 = 32833;
        public const System.Int32 GL_LUMINANCE16 = 32834;
        public const System.Int32 GL_LUMINANCE4_ALPHA4 = 32835;
        public const System.Int32 GL_LUMINANCE6_ALPHA2 = 32836;
        public const System.Int32 GL_LUMINANCE8_ALPHA8 = 32837;
        public const System.Int32 GL_LUMINANCE12_ALPHA4 = 32838;
        public const System.Int32 GL_LUMINANCE12_ALPHA12 = 32839;
        public const System.Int32 GL_LUMINANCE16_ALPHA16 = 32840;
        public const System.Int32 GL_INTENSITY = 32841;
        public const System.Int32 GL_INTENSITY4 = 32842;
        public const System.Int32 GL_INTENSITY8 = 32843;
        public const System.Int32 GL_INTENSITY12 = 32844;
        public const System.Int32 GL_INTENSITY16 = 32845;
        public const System.Int32 GL_R3_G3_B2 = 10768;
        public const System.Int32 GL_RGB4 = 32847;
        public const System.Int32 GL_RGB5 = 32848;
        public const System.Int32 GL_RGB8 = 32849;
        public const System.Int32 GL_RGB10 = 32850;
        public const System.Int32 GL_RGB12 = 32851;
        public const System.Int32 GL_RGB16 = 32852;
        public const System.Int32 GL_RGBA2 = 32853;
        public const System.Int32 GL_RGBA4 = 32854;
        public const System.Int32 GL_RGB5_A1 = 32855;
        public const System.Int32 GL_RGBA8 = 32856;
        public const System.Int32 GL_RGB10_A2 = 32857;
        public const System.Int32 GL_RGBA12 = 32858;
        public const System.Int32 GL_RGBA16 = 32859;
        public const System.Int32 GL_TEXTURE_RED_SIZE = 32860;
        public const System.Int32 GL_TEXTURE_GREEN_SIZE = 32861;
        public const System.Int32 GL_TEXTURE_BLUE_SIZE = 32862;
        public const System.Int32 GL_TEXTURE_ALPHA_SIZE = 32863;
        public const System.Int32 GL_TEXTURE_LUMINANCE_SIZE = 32864;
        public const System.Int32 GL_TEXTURE_INTENSITY_SIZE = 32865;
        public const System.Int32 GL_PROXY_TEXTURE_1D = 32867;
        public const System.Int32 GL_PROXY_TEXTURE_2D = 32868;
        public const System.Int32 GL_TEXTURE_PRIORITY = 32870;
        public const System.Int32 GL_TEXTURE_RESIDENT = 32871;
        public const System.Int32 GL_TEXTURE_BINDING_1D = 32872;
        public const System.Int32 GL_TEXTURE_BINDING_2D = 32873;
        public const System.Int32 GL_VERTEX_ARRAY = 32884;
        public const System.Int32 GL_NORMAL_ARRAY = 32885;
        public const System.Int32 GL_COLOR_ARRAY = 32886;
        public const System.Int32 GL_INDEX_ARRAY = 32887;
        public const System.Int32 GL_TEXTURE_COORD_ARRAY = 32888;
        public const System.Int32 GL_EDGE_FLAG_ARRAY = 32889;
        public const System.Int32 GL_VERTEX_ARRAY_SIZE = 32890;
        public const System.Int32 GL_VERTEX_ARRAY_TYPE = 32891;
        public const System.Int32 GL_VERTEX_ARRAY_STRIDE = 32892;
        public const System.Int32 GL_NORMAL_ARRAY_TYPE = 32894;
        public const System.Int32 GL_NORMAL_ARRAY_STRIDE = 32895;
        public const System.Int32 GL_COLOR_ARRAY_SIZE = 32897;
        public const System.Int32 GL_COLOR_ARRAY_TYPE = 32898;
        public const System.Int32 GL_COLOR_ARRAY_STRIDE = 32899;
        public const System.Int32 GL_INDEX_ARRAY_TYPE = 32901;
        public const System.Int32 GL_INDEX_ARRAY_STRIDE = 32902;
        public const System.Int32 GL_TEXTURE_COORD_ARRAY_SIZE = 32904;
        public const System.Int32 GL_TEXTURE_COORD_ARRAY_TYPE = 32905;
        public const System.Int32 GL_TEXTURE_COORD_ARRAY_STRIDE = 32906;
        public const System.Int32 GL_EDGE_FLAG_ARRAY_STRIDE = 32908;
        public const System.Int32 GL_VERTEX_ARRAY_POINTER = 32910;
        public const System.Int32 GL_NORMAL_ARRAY_POINTER = 32911;
        public const System.Int32 GL_COLOR_ARRAY_POINTER = 32912;
        public const System.Int32 GL_INDEX_ARRAY_POINTER = 32913;
        public const System.Int32 GL_TEXTURE_COORD_ARRAY_POINTER = 32914;
        public const System.Int32 GL_EDGE_FLAG_ARRAY_POINTER = 32915;
        public const System.Int32 GL_V2F = 10784;
        public const System.Int32 GL_V3F = 10785;
        public const System.Int32 GL_C4UB_V2F = 10786;
        public const System.Int32 GL_C4UB_V3F = 10787;
        public const System.Int32 GL_C3F_V3F = 10788;
        public const System.Int32 GL_N3F_V3F = 10789;
        public const System.Int32 GL_C4F_N3F_V3F = 10790;
        public const System.Int32 GL_T2F_V3F = 10791;
        public const System.Int32 GL_T4F_V4F = 10792;
        public const System.Int32 GL_T2F_C4UB_V3F = 10793;
        public const System.Int32 GL_T2F_C3F_V3F = 10794;
        public const System.Int32 GL_T2F_N3F_V3F = 10795;
        public const System.Int32 GL_T2F_C4F_N3F_V3F = 10796;
        public const System.Int32 GL_T4F_C4F_N3F_V4F = 10797;
        public const System.Int32 GL_LOGIC_OP = 3057;
        public const System.Int32 GL_TEXTURE_COMPONENTS = 4099;
        #endregion
        #region OpenGL X.X delegates
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glAccumPROC(uint op, float value);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glAlphaFuncPROC(uint func, float ref_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glClearColorPROC(float red, float green, float blue, float alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glClearAccumPROC(float red, float green, float blue, float alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glClearPROC(uint mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCallListsPROC(int n, uint type, void* lists);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCallListPROC(uint list);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glBlendFuncPROC(uint sfactor, uint dfactor);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glBitmapPROC(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glBindTexturePROC(uint target, uint texture);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPrioritizeTexturesPROC(int n, uint* textures, float* priorities);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate bool glAreTexturesResidentPROC(int n, uint* textures, bool* residences);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glBeginPROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEndPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glArrayElementPROC(int i);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glClearDepthPROC(double depth);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDeleteListsPROC(uint list, int range);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDeleteTexturesPROC(int n, uint* textures);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCullFacePROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCopyTexSubImage2DPROC(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCopyTexSubImage1DPROC(uint target, int level, int xoffset, int x, int y, int width);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCopyTexImage2DPROC(uint target, int level, int internalFormat, int x, int y, int width, int height, int border);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCopyTexImage1DPROC(uint target, int level, int internalFormat, int x, int y, int width, int border);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glCopyPixelsPROC(int x, int y, int width, int height, int type);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColorPointerPROC(int size, uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColorMaterialPROC(uint face, uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColorMaskPROC(bool red, bool green, bool blue, bool alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor3bPROC(byte red, byte green, byte blue);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor3fPROC(float red, float green, float blue);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor3dPROC(double red, double green, double blue);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor3ubPROC(byte red, byte green, byte blue);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor4bPROC(byte red, byte green, byte blue, byte alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor4fPROC(float red, float green, float blue, float alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor4dPROC(double red, double green, double blue, double alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glColor4ubPROC(byte red, byte green, byte blue, byte alpha);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glClipPlanePROC(uint plane, double* equation);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glClearStencilPROC(int s);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalPoint1PROC(int i);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalPoint2PROC(int i, int j);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalMesh1PROC(uint mode, int i1, int i2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalMesh2PROC(uint mode, int i1, int i2, int j1, int j2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalCoord1fPROC(float u);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalCoord1dPROC(double u);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalCoord2fPROC(float u, float v);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEvalCoord2dPROC(double u, double v);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEnableClientStatePROC(uint cap);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDisableClientStatePROC(uint cap);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEnablePROC(uint cap);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDisablePROC(uint cap);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEdgeFlagPointerPROC(int stride, void* pointer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEdgeFlagPROC(byte flag);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDrawPixelsPROC(int width, int height, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDrawElementsPROC(uint mode, int count, uint type, void* indices);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDrawBufferPROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDrawArraysPROC(uint mode, int first, int count);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDepthRangePROC(double zNear, double zFar);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDepthMaskPROC(byte flag);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glDepthFuncPROC(uint func);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFeedbackBufferPROC(int size, uint type, float* buffer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetPixelMapfvPROC(uint map, float* values);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetPixelMapuivPROC(uint map, uint* values);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetPixelMapusvPROC(uint map, ushort* values);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetMaterialfvPROC(uint face, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetMaterialivPROC(uint face, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetMapfvPROC(uint target, uint query, float* v);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetMapdvPROC(uint target, uint query, double* v);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetMapivPROC(uint target, uint query, int* v);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetLightfvPROC(uint light, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetLightivPROC(uint light, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate int glGetErrorPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetClipPlanePROC(uint plane, double* equation);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetBooleanvPROC(uint pname, bool* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetDoublevPROC(uint pname, double* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetFloatvPROC(uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetIntegervPROC(uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGenTexturesPROC(int n, uint* textures);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate uint glGenListsPROC(int range);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFrustumPROC(double left, double right, double bottom, double top, double zNear, double zFar);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFrontFacePROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFogfPROC(uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFogiPROC(uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFogfvPROC(uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFogivPROC(uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFlushPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glFinishPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetPointervPROC(uint pname, void** result);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate bool glIsEnabledPROC(uint cap);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glInterleavedArraysPROC(uint format, int stride, void* pointer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glInitNamesPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glHintPROC(uint target, uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexParameterfvPROC(uint target, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexParameterivPROC(uint target, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexLevelParameterfvPROC(uint target, int level, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexLevelParameterivPROC(uint target, int level, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexImagePROC(uint target, int level, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexGenivPROC(uint coord, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexGenfvPROC(uint coord, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexGendvPROC(uint coord, uint pname, double* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexEnvivPROC(uint coord, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetTexEnvfvPROC(uint coord, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate byte* glGetStringPROC(int name);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glGetPolygonStipplePROC(byte* mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate bool glIsListPROC(uint list);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMaterialfPROC(uint face, uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMaterialiPROC(uint face, uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMaterialfvPROC(uint face, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMaterialivPROC(uint face, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMapGrid1fPROC(int un, float u1, float u2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMapGrid1dPROC(int un, double u1, double u2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMapGrid2fPROC(int un, float u1, float u2, int vn, float v1, float v2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMapGrid2dPROC(int un, double u1, double u2, int vn, double v1, double v2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMap2fPROC(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMap2dPROC(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMap1fPROC(uint target, float u1, float u2, int stride, int order, float* points);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMap1dPROC(uint target, double u1, double u2, int stride, int order, double* points);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLogicOpPROC(uint opcode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLoadNamePROC(uint name);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLoadMatrixfPROC(float* m);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLoadMatrixdPROC(double* m);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLoadIdentityPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glListBasePROC(uint base_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLineWidthPROC(float width);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLineStipplePROC(int factor, ushort pattern);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightModelfPROC(uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightModeliPROC(uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightModelfvPROC(uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightModelivPROC(uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightfPROC(uint light, uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightiPROC(uint light, uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightfvPROC(uint light, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glLightivPROC(uint light, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate bool glIsTexturePROC(uint texture);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMatrixModePROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPolygonStipplePROC(byte* mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPolygonOffsetPROC(float factor, float units);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPolygonModePROC(uint face, uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPointSizePROC(float size);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelZoomPROC(float xfactor, float yfactor);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelTransferfPROC(uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelTransferiPROC(uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelStorefPROC(uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelStoreiPROC(uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelMapfvPROC(uint map, int mapsize, float* values);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelMapuivPROC(uint map, int mapsize, uint* values);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPixelMapusvPROC(uint map, int mapsize, ushort* values);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPassThroughPROC(float token);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glOrthoPROC(double left, double right, double bottom, double top, double zNear, double zFar);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glNormalPointerPROC(uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glNormal3bPROC(byte nx, byte ny, byte nz);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glNormal3fPROC(float nx, float ny, float nz);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glNormal3dPROC(double nx, double ny, double nz);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glNormal3iPROC(int nx, int ny, int nz);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glNewListPROC(uint list, uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glEndListPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMultMatrixfPROC(float* m);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glMultMatrixdPROC(double* m);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glShadeModelPROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glSelectBufferPROC(int size, uint* buffer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glScissorPROC(int x, int y, int width, int height);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glScalefPROC(float x, float y, float z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glScaledPROC(double x, double y, double z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRotatefPROC(float angle, float x, float y, float z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate int glRenderModePROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRectfPROC(float x1, float y1, float x2, float y2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRectdPROC(double x1, double y1, double x2, double y2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRectiPROC(int x1, int y1, int x2, int y2);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glReadPixelsPROC(int x, int y, int width, int height, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glReadBufferPROC(uint mode);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos2fPROC(float x, float y);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos2dPROC(double x, double y);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos2iPROC(int x, int y);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos3fPROC(float x, float y, float z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos3dPROC(double x, double y, double z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos3iPROC(int x, int y, int z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos4fPROC(float x, float y, float z, float w);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos4dPROC(double x, double y, double z, double w);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glRasterPos4iPROC(int x, int y, int z, int w);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPushNamePROC(uint name);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPopNamePROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPushMatrixPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPopMatrixPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPushClientAttribPROC(uint mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPopClientAttribPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPushAttribPROC(uint mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glPopAttribPROC();

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glStencilFuncPROC(uint func, int ref_, uint mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertexPointerPROC(int size, uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex2fPROC(float x, float y);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex2dPROC(double x, double y);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex2iPROC(int x, int y);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex3fPROC(float x, float y, float z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex3dPROC(double x, double y, double z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex3iPROC(int x, int y, int z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex4fPROC(float x, float y, float z, float w);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex4dPROC(double x, double y, double z, double w);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glVertex4iPROC(int x, int y, int z, int w);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTranslatefPROC(float x, float y, float z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTranslatedPROC(double x, double y, double z);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexImage1DPROC(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexImage2DPROC(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexSubImage1DPROC(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexSubImage2DPROC(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexParameterfPROC(uint target, uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexParameteriPROC(uint target, uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexParameterfvPROC(uint target, uint pname, float* param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexParameterivPROC(uint target, uint pname, int* param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexGenfPROC(uint coord, uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexGendPROC(uint coord, uint pname, double param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexGenfvPROC(uint coord, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexGendvPROC(uint coord, uint pname, double* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexGeniPROC(uint coord, uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexGenivPROC(uint coord, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexEnvfPROC(uint target, uint pname, float param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexEnviPROC(uint target, uint pname, int param);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexEnvfvPROC(uint target, uint pname, float* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexEnvivPROC(uint target, uint pname, int* params_);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoordPointerPROC(int size, uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord1fPROC(float s);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord1dPROC(double s);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord2fPROC(float s, float t);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord2dPROC(double s, double t);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord3fPROC(float s, float t, float r);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord3dPROC(double s, double t, double r);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord4fPROC(float s, float t, float r, float q);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glTexCoord4dPROC(double s, double t, double r, double q);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glStencilOpPROC(uint fail, uint zfail, uint zpass);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glStencilMaskPROC(uint mask);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
        private delegate void glViewportPROC(int x, int y, int width, int height);

        #endregion
        #region OpenGL X.X delegates functions
        public const string openGL_DLL = "opengl32.dll";

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glAccum", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glAccumPROCF(uint op, float value);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glAlphaFunc", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glAlphaFuncPROCF(uint func, float ref_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glClearColor", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glClearColorPROCF(float red, float green, float blue, float alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glClearAccum", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glClearAccumPROCF(float red, float green, float blue, float alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glClear", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glClearPROCF(uint mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCallLists", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCallListsPROCF(int n, uint type, void* lists);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCallList", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCallListPROCF(uint list);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glBlendFunc", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glBlendFuncPROCF(uint sfactor, uint dfactor);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glBitmap", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glBitmapPROCF(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glBindTexture", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glBindTexturePROCF(uint target, uint texture);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPrioritizeTextures", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPrioritizeTexturesPROCF(int n, uint* textures, float* priorities);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glAreTexturesResident", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool glAreTexturesResidentPROCF(int n, uint* textures, bool* residences);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glBegin", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glBeginPROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEnd", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEndPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glArrayElement", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glArrayElementPROCF(int i);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glClearDepth", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glClearDepthPROCF(double depth);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDeleteLists", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDeleteListsPROCF(uint list, int range);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDeleteTextures", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDeleteTexturesPROCF(int n, uint* textures);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCullFace", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCullFacePROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCopyTexSubImage2D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCopyTexSubImage2DPROCF(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCopyTexSubImage1D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCopyTexSubImage1DPROCF(uint target, int level, int xoffset, int x, int y, int width);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCopyTexImage2D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCopyTexImage2DPROCF(uint target, int level, int internalFormat, int x, int y, int width, int height, int border);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCopyTexImage1D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCopyTexImage1DPROCF(uint target, int level, int internalFormat, int x, int y, int width, int border);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glCopyPixels", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glCopyPixelsPROCF(int x, int y, int width, int height, int type);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColorPointer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColorPointerPROCF(int size, uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColorMaterial", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColorMaterialPROCF(uint face, uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColorMask", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColorMaskPROCF(bool red, bool green, bool blue, bool alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor3b", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor3bPROCF(byte red, byte green, byte blue);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor3f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor3fPROCF(float red, float green, float blue);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor3d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor3dPROCF(double red, double green, double blue);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor3ub", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor3ubPROCF(byte red, byte green, byte blue);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor4b", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor4bPROCF(byte red, byte green, byte blue, byte alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor4f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor4fPROCF(float red, float green, float blue, float alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor4d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor4dPROCF(double red, double green, double blue, double alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glColor4ub", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glColor4ubPROCF(byte red, byte green, byte blue, byte alpha);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glClipPlane", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glClipPlanePROCF(uint plane, double* equation);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glClearStencil", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glClearStencilPROCF(int s);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalPoint1", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalPoint1PROCF(int i);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalPoint2", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalPoint2PROCF(int i, int j);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalMesh1", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalMesh1PROCF(uint mode, int i1, int i2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalMesh2", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalMesh2PROCF(uint mode, int i1, int i2, int j1, int j2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalCoord1f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalCoord1fPROCF(float u);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalCoord1d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalCoord1dPROCF(double u);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalCoord2f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalCoord2fPROCF(float u, float v);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEvalCoord2d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEvalCoord2dPROCF(double u, double v);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEnableClientState", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEnableClientStatePROCF(uint cap);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDisableClientState", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDisableClientStatePROCF(uint cap);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEnable", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEnablePROCF(uint cap);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDisable", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDisablePROCF(uint cap);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEdgeFlagPointer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEdgeFlagPointerPROCF(int stride, void* pointer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEdgeFlag", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEdgeFlagPROCF(byte flag);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDrawPixels", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDrawPixelsPROCF(int width, int height, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDrawElements", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDrawElementsPROCF(uint mode, int count, uint type, void* indices);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDrawBuffer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDrawBufferPROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDrawArrays", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDrawArraysPROCF(uint mode, int first, int count);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDepthRange", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDepthRangePROCF(double zNear, double zFar);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDepthMask", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDepthMaskPROCF(byte flag);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glDepthFunc", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glDepthFuncPROCF(uint func);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFeedbackBuffer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFeedbackBufferPROCF(int size, uint type, float* buffer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetPixelMapfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetPixelMapfvPROCF(uint map, float* values);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetPixelMapuiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetPixelMapuivPROCF(uint map, uint* values);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetPixelMapusv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetPixelMapusvPROCF(uint map, ushort* values);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetMaterialfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetMaterialfvPROCF(uint face, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetMaterialiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetMaterialivPROCF(uint face, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetMapfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetMapfvPROCF(uint target, uint query, float* v);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetMapdv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetMapdvPROCF(uint target, uint query, double* v);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetMapiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetMapivPROCF(uint target, uint query, int* v);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetLightfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetLightfvPROCF(uint light, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetLightiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetLightivPROCF(uint light, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetError", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int glGetErrorPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetClipPlane", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetClipPlanePROCF(uint plane, double* equation);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetBooleanv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetBooleanvPROCF(uint pname, bool* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetDoublev", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetDoublevPROCF(uint pname, double* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetFloatv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetFloatvPROCF(uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetIntegerv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetIntegervPROCF(uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGenTextures", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGenTexturesPROCF(int n, uint* textures);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGenLists", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern uint glGenListsPROCF(int range);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFrustum", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFrustumPROCF(double left, double right, double bottom, double top, double zNear, double zFar);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFrontFace", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFrontFacePROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFogf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFogfPROCF(uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFogi", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFogiPROCF(uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFogfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFogfvPROCF(uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFogiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFogivPROCF(uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFlush", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFlushPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glFinish", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glFinishPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetPointerv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetPointervPROCF(uint pname, void** result);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glIsEnabled", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool glIsEnabledPROCF(uint cap);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glInterleavedArrays", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glInterleavedArraysPROCF(uint format, int stride, void* pointer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glInitNames", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glInitNamesPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glHint", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glHintPROCF(uint target, uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexParameterfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexParameterfvPROCF(uint target, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexParameteriv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexParameterivPROCF(uint target, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexLevelParameterfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexLevelParameterfvPROCF(uint target, int level, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexLevelParameteriv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexLevelParameterivPROCF(uint target, int level, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexImage", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexImagePROCF(uint target, int level, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexGeniv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexGenivPROCF(uint coord, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexGenfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexGenfvPROCF(uint coord, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexGendv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexGendvPROCF(uint coord, uint pname, double* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexEnviv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexEnvivPROCF(uint coord, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetTexEnvfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetTexEnvfvPROCF(uint coord, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetString", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern byte* glGetStringPROCF(int name);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glGetPolygonStipple", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glGetPolygonStipplePROCF(byte* mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glIsList", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool glIsListPROCF(uint list);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMaterialf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMaterialfPROCF(uint face, uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMateriali", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMaterialiPROCF(uint face, uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMaterialfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMaterialfvPROCF(uint face, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMaterialiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMaterialivPROCF(uint face, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMapGrid1f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMapGrid1fPROCF(int un, float u1, float u2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMapGrid1d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMapGrid1dPROCF(int un, double u1, double u2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMapGrid2f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMapGrid2fPROCF(int un, float u1, float u2, int vn, float v1, float v2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMapGrid2d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMapGrid2dPROCF(int un, double u1, double u2, int vn, double v1, double v2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMap2f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMap2fPROCF(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMap2d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMap2dPROCF(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMap1f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMap1fPROCF(uint target, float u1, float u2, int stride, int order, float* points);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMap1d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMap1dPROCF(uint target, double u1, double u2, int stride, int order, double* points);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLogicOp", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLogicOpPROCF(uint opcode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLoadName", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLoadNamePROCF(uint name);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLoadMatrixf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLoadMatrixfPROCF(float* m);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLoadMatrixd", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLoadMatrixdPROCF(double* m);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLoadIdentity", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLoadIdentityPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glListBase", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glListBasePROCF(uint base_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLineWidth", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLineWidthPROCF(float width);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLineStipple", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLineStipplePROCF(int factor, ushort pattern);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightModelf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightModelfPROCF(uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightModeli", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightModeliPROCF(uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightModelfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightModelfvPROCF(uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightModeliv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightModelivPROCF(uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightfPROCF(uint light, uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLighti", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightiPROCF(uint light, uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightfvPROCF(uint light, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glLightiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glLightivPROCF(uint light, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glIsTexture", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern bool glIsTexturePROCF(uint texture);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMatrixMode", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMatrixModePROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPolygonStipple", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPolygonStipplePROCF(byte* mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPolygonOffset", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPolygonOffsetPROCF(float factor, float units);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPolygonMode", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPolygonModePROCF(uint face, uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPointSize", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPointSizePROCF(float size);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelZoom", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelZoomPROCF(float xfactor, float yfactor);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelTransferf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelTransferfPROCF(uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelTransferi", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelTransferiPROCF(uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelStoref", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelStorefPROCF(uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelStorei", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelStoreiPROCF(uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelMapfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelMapfvPROCF(uint map, int mapsize, float* values);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelMapuiv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelMapuivPROCF(uint map, int mapsize, uint* values);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPixelMapusv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPixelMapusvPROCF(uint map, int mapsize, ushort* values);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPassThrough", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPassThroughPROCF(float token);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glOrtho", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glOrthoPROCF(double left, double right, double bottom, double top, double zNear, double zFar);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glNormalPointer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glNormalPointerPROCF(uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glNormal3b", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glNormal3bPROCF(byte nx, byte ny, byte nz);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glNormal3f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glNormal3fPROCF(float nx, float ny, float nz);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glNormal3d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glNormal3dPROCF(double nx, double ny, double nz);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glNormal3i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glNormal3iPROCF(int nx, int ny, int nz);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glNewList", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glNewListPROCF(uint list, uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glEndList", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glEndListPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMultMatrixf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMultMatrixfPROCF(float* m);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glMultMatrixd", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glMultMatrixdPROCF(double* m);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glShadeModel", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glShadeModelPROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glSelectBuffer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glSelectBufferPROCF(int size, uint* buffer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glScissor", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glScissorPROCF(int x, int y, int width, int height);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glScalef", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glScalefPROCF(float x, float y, float z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glScaled", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glScaledPROCF(double x, double y, double z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRotatef", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRotatefPROCF(float angle, float x, float y, float z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRenderMode", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern int glRenderModePROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRectf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRectfPROCF(float x1, float y1, float x2, float y2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRectd", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRectdPROCF(double x1, double y1, double x2, double y2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRecti", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRectiPROCF(int x1, int y1, int x2, int y2);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glReadPixels", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glReadPixelsPROCF(int x, int y, int width, int height, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glReadBuffer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glReadBufferPROCF(uint mode);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos2f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos2fPROCF(float x, float y);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos2d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos2dPROCF(double x, double y);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos2i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos2iPROCF(int x, int y);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos3f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos3fPROCF(float x, float y, float z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos3d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos3dPROCF(double x, double y, double z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos3i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos3iPROCF(int x, int y, int z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos4f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos4fPROCF(float x, float y, float z, float w);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos4d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos4dPROCF(double x, double y, double z, double w);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glRasterPos4i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glRasterPos4iPROCF(int x, int y, int z, int w);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPushName", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPushNamePROCF(uint name);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPopName", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPopNamePROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPushMatrix", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPushMatrixPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPopMatrix", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPopMatrixPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPushClientAttrib", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPushClientAttribPROCF(uint mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPopClientAttrib", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPopClientAttribPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPushAttrib", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPushAttribPROCF(uint mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glPopAttrib", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glPopAttribPROCF();

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glStencilFunc", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glStencilFuncPROCF(uint func, int ref_, uint mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertexPointer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertexPointerPROCF(int size, uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex2f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex2fPROCF(float x, float y);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex2d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex2dPROCF(double x, double y);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex2i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex2iPROCF(int x, int y);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex3f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex3fPROCF(float x, float y, float z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex3d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex3dPROCF(double x, double y, double z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex3i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex3iPROCF(int x, int y, int z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex4f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex4fPROCF(float x, float y, float z, float w);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex4d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex4dPROCF(double x, double y, double z, double w);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glVertex4i", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glVertex4iPROCF(int x, int y, int z, int w);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTranslatef", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTranslatefPROCF(float x, float y, float z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTranslated", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTranslatedPROCF(double x, double y, double z);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexImage1D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexImage1DPROCF(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexImage2D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexImage2DPROCF(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexSubImage1D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexSubImage1DPROCF(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexSubImage2D", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexSubImage2DPROCF(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexParameterf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexParameterfPROCF(uint target, uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexParameteri", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexParameteriPROCF(uint target, uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexParameterfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexParameterfvPROCF(uint target, uint pname, float* param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexParameteriv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexParameterivPROCF(uint target, uint pname, int* param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexGenf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexGenfPROCF(uint coord, uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexGend", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexGendPROCF(uint coord, uint pname, double param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexGenfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexGenfvPROCF(uint coord, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexGendv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexGendvPROCF(uint coord, uint pname, double* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexGeni", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexGeniPROCF(uint coord, uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexGeniv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexGenivPROCF(uint coord, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexEnvf", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexEnvfPROCF(uint target, uint pname, float param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexEnvi", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexEnviPROCF(uint target, uint pname, int param);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexEnvfv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexEnvfvPROCF(uint target, uint pname, float* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexEnviv", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexEnvivPROCF(uint target, uint pname, int* params_);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoordPointer", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoordPointerPROCF(int size, uint type, int stride, void* pointer);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord1f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord1fPROCF(float s);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord1d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord1dPROCF(double s);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord2f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord2fPROCF(float s, float t);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord2d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord2dPROCF(double s, double t);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord3f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord3fPROCF(float s, float t, float r);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord3d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord3dPROCF(double s, double t, double r);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord4f", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord4fPROCF(float s, float t, float r, float q);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glTexCoord4d", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glTexCoord4dPROCF(double s, double t, double r, double q);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glStencilOp", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glStencilOpPROCF(uint fail, uint zfail, uint zpass);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glStencilMask", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glStencilMaskPROCF(uint mask);

        [System.Runtime.InteropServices.DllImport(openGL_DLL, EntryPoint = "glViewport", SetLastError = true, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        private static extern void glViewportPROCF(int x, int y, int width, int height);

        #endregion
        #region OpenGL X.X addresses
        private static glAccumPROC glAccumADDRESS = null;

        private static glAlphaFuncPROC glAlphaFuncADDRESS = null;

        private static glClearColorPROC glClearColorADDRESS = null;

        private static glClearAccumPROC glClearAccumADDRESS = null;

        private static glClearPROC glClearADDRESS = null;

        private static glCallListsPROC glCallListsADDRESS = null;

        private static glCallListPROC glCallListADDRESS = null;

        private static glBlendFuncPROC glBlendFuncADDRESS = null;

        private static glBitmapPROC glBitmapADDRESS = null;

        private static glBindTexturePROC glBindTextureADDRESS = null;

        private static glPrioritizeTexturesPROC glPrioritizeTexturesADDRESS = null;

        private static glAreTexturesResidentPROC glAreTexturesResidentADDRESS = null;

        private static glBeginPROC glBeginADDRESS = null;

        private static glEndPROC glEndADDRESS = null;

        private static glArrayElementPROC glArrayElementADDRESS = null;

        private static glClearDepthPROC glClearDepthADDRESS = null;

        private static glDeleteListsPROC glDeleteListsADDRESS = null;

        private static glDeleteTexturesPROC glDeleteTexturesADDRESS = null;

        private static glCullFacePROC glCullFaceADDRESS = null;

        private static glCopyTexSubImage2DPROC glCopyTexSubImage2DADDRESS = null;

        private static glCopyTexSubImage1DPROC glCopyTexSubImage1DADDRESS = null;

        private static glCopyTexImage2DPROC glCopyTexImage2DADDRESS = null;

        private static glCopyTexImage1DPROC glCopyTexImage1DADDRESS = null;

        private static glCopyPixelsPROC glCopyPixelsADDRESS = null;

        private static glColorPointerPROC glColorPointerADDRESS = null;

        private static glColorMaterialPROC glColorMaterialADDRESS = null;

        private static glColorMaskPROC glColorMaskADDRESS = null;

        private static glColor3bPROC glColor3bADDRESS = null;

        private static glColor3fPROC glColor3fADDRESS = null;

        private static glColor3dPROC glColor3dADDRESS = null;

        private static glColor3ubPROC glColor3ubADDRESS = null;

        private static glColor4bPROC glColor4bADDRESS = null;

        private static glColor4fPROC glColor4fADDRESS = null;

        private static glColor4dPROC glColor4dADDRESS = null;

        private static glColor4ubPROC glColor4ubADDRESS = null;

        private static glClipPlanePROC glClipPlaneADDRESS = null;

        private static glClearStencilPROC glClearStencilADDRESS = null;

        private static glEvalPoint1PROC glEvalPoint1ADDRESS = null;

        private static glEvalPoint2PROC glEvalPoint2ADDRESS = null;

        private static glEvalMesh1PROC glEvalMesh1ADDRESS = null;

        private static glEvalMesh2PROC glEvalMesh2ADDRESS = null;

        private static glEvalCoord1fPROC glEvalCoord1fADDRESS = null;

        private static glEvalCoord1dPROC glEvalCoord1dADDRESS = null;

        private static glEvalCoord2fPROC glEvalCoord2fADDRESS = null;

        private static glEvalCoord2dPROC glEvalCoord2dADDRESS = null;

        private static glEnableClientStatePROC glEnableClientStateADDRESS = null;

        private static glDisableClientStatePROC glDisableClientStateADDRESS = null;

        private static glEnablePROC glEnableADDRESS = null;

        private static glDisablePROC glDisableADDRESS = null;

        private static glEdgeFlagPointerPROC glEdgeFlagPointerADDRESS = null;

        private static glEdgeFlagPROC glEdgeFlagADDRESS = null;

        private static glDrawPixelsPROC glDrawPixelsADDRESS = null;

        private static glDrawElementsPROC glDrawElementsADDRESS = null;

        private static glDrawBufferPROC glDrawBufferADDRESS = null;

        private static glDrawArraysPROC glDrawArraysADDRESS = null;

        private static glDepthRangePROC glDepthRangeADDRESS = null;

        private static glDepthMaskPROC glDepthMaskADDRESS = null;

        private static glDepthFuncPROC glDepthFuncADDRESS = null;

        private static glFeedbackBufferPROC glFeedbackBufferADDRESS = null;

        private static glGetPixelMapfvPROC glGetPixelMapfvADDRESS = null;

        private static glGetPixelMapuivPROC glGetPixelMapuivADDRESS = null;

        private static glGetPixelMapusvPROC glGetPixelMapusvADDRESS = null;

        private static glGetMaterialfvPROC glGetMaterialfvADDRESS = null;

        private static glGetMaterialivPROC glGetMaterialivADDRESS = null;

        private static glGetMapfvPROC glGetMapfvADDRESS = null;

        private static glGetMapdvPROC glGetMapdvADDRESS = null;

        private static glGetMapivPROC glGetMapivADDRESS = null;

        private static glGetLightfvPROC glGetLightfvADDRESS = null;

        private static glGetLightivPROC glGetLightivADDRESS = null;

        private static glGetErrorPROC glGetErrorADDRESS = null;

        private static glGetClipPlanePROC glGetClipPlaneADDRESS = null;

        private static glGetBooleanvPROC glGetBooleanvADDRESS = null;

        private static glGetDoublevPROC glGetDoublevADDRESS = null;

        private static glGetFloatvPROC glGetFloatvADDRESS = null;

        private static glGetIntegervPROC glGetIntegervADDRESS = null;

        private static glGenTexturesPROC glGenTexturesADDRESS = null;

        private static glGenListsPROC glGenListsADDRESS = null;

        private static glFrustumPROC glFrustumADDRESS = null;

        private static glFrontFacePROC glFrontFaceADDRESS = null;

        private static glFogfPROC glFogfADDRESS = null;

        private static glFogiPROC glFogiADDRESS = null;

        private static glFogfvPROC glFogfvADDRESS = null;

        private static glFogivPROC glFogivADDRESS = null;

        private static glFlushPROC glFlushADDRESS = null;

        private static glFinishPROC glFinishADDRESS = null;

        private static glGetPointervPROC glGetPointervADDRESS = null;

        private static glIsEnabledPROC glIsEnabledADDRESS = null;

        private static glInterleavedArraysPROC glInterleavedArraysADDRESS = null;

        private static glInitNamesPROC glInitNamesADDRESS = null;

        private static glHintPROC glHintADDRESS = null;

        private static glGetTexParameterfvPROC glGetTexParameterfvADDRESS = null;

        private static glGetTexParameterivPROC glGetTexParameterivADDRESS = null;

        private static glGetTexLevelParameterfvPROC glGetTexLevelParameterfvADDRESS = null;

        private static glGetTexLevelParameterivPROC glGetTexLevelParameterivADDRESS = null;

        private static glGetTexImagePROC glGetTexImageADDRESS = null;

        private static glGetTexGenivPROC glGetTexGenivADDRESS = null;

        private static glGetTexGenfvPROC glGetTexGenfvADDRESS = null;

        private static glGetTexGendvPROC glGetTexGendvADDRESS = null;

        private static glGetTexEnvivPROC glGetTexEnvivADDRESS = null;

        private static glGetTexEnvfvPROC glGetTexEnvfvADDRESS = null;

        private static glGetStringPROC glGetStringADDRESS = null;

        private static glGetPolygonStipplePROC glGetPolygonStippleADDRESS = null;

        private static glIsListPROC glIsListADDRESS = null;

        private static glMaterialfPROC glMaterialfADDRESS = null;

        private static glMaterialiPROC glMaterialiADDRESS = null;

        private static glMaterialfvPROC glMaterialfvADDRESS = null;

        private static glMaterialivPROC glMaterialivADDRESS = null;

        private static glMapGrid1fPROC glMapGrid1fADDRESS = null;

        private static glMapGrid1dPROC glMapGrid1dADDRESS = null;

        private static glMapGrid2fPROC glMapGrid2fADDRESS = null;

        private static glMapGrid2dPROC glMapGrid2dADDRESS = null;

        private static glMap2fPROC glMap2fADDRESS = null;

        private static glMap2dPROC glMap2dADDRESS = null;

        private static glMap1fPROC glMap1fADDRESS = null;

        private static glMap1dPROC glMap1dADDRESS = null;

        private static glLogicOpPROC glLogicOpADDRESS = null;

        private static glLoadNamePROC glLoadNameADDRESS = null;

        private static glLoadMatrixfPROC glLoadMatrixfADDRESS = null;

        private static glLoadMatrixdPROC glLoadMatrixdADDRESS = null;

        private static glLoadIdentityPROC glLoadIdentityADDRESS = null;

        private static glListBasePROC glListBaseADDRESS = null;

        private static glLineWidthPROC glLineWidthADDRESS = null;

        private static glLineStipplePROC glLineStippleADDRESS = null;

        private static glLightModelfPROC glLightModelfADDRESS = null;

        private static glLightModeliPROC glLightModeliADDRESS = null;

        private static glLightModelfvPROC glLightModelfvADDRESS = null;

        private static glLightModelivPROC glLightModelivADDRESS = null;

        private static glLightfPROC glLightfADDRESS = null;

        private static glLightiPROC glLightiADDRESS = null;

        private static glLightfvPROC glLightfvADDRESS = null;

        private static glLightivPROC glLightivADDRESS = null;

        private static glIsTexturePROC glIsTextureADDRESS = null;

        private static glMatrixModePROC glMatrixModeADDRESS = null;

        private static glPolygonStipplePROC glPolygonStippleADDRESS = null;

        private static glPolygonOffsetPROC glPolygonOffsetADDRESS = null;

        private static glPolygonModePROC glPolygonModeADDRESS = null;

        private static glPointSizePROC glPointSizeADDRESS = null;

        private static glPixelZoomPROC glPixelZoomADDRESS = null;

        private static glPixelTransferfPROC glPixelTransferfADDRESS = null;

        private static glPixelTransferiPROC glPixelTransferiADDRESS = null;

        private static glPixelStorefPROC glPixelStorefADDRESS = null;

        private static glPixelStoreiPROC glPixelStoreiADDRESS = null;

        private static glPixelMapfvPROC glPixelMapfvADDRESS = null;

        private static glPixelMapuivPROC glPixelMapuivADDRESS = null;

        private static glPixelMapusvPROC glPixelMapusvADDRESS = null;

        private static glPassThroughPROC glPassThroughADDRESS = null;

        private static glOrthoPROC glOrthoADDRESS = null;

        private static glNormalPointerPROC glNormalPointerADDRESS = null;

        private static glNormal3bPROC glNormal3bADDRESS = null;

        private static glNormal3fPROC glNormal3fADDRESS = null;

        private static glNormal3dPROC glNormal3dADDRESS = null;

        private static glNormal3iPROC glNormal3iADDRESS = null;

        private static glNewListPROC glNewListADDRESS = null;

        private static glEndListPROC glEndListADDRESS = null;

        private static glMultMatrixfPROC glMultMatrixfADDRESS = null;

        private static glMultMatrixdPROC glMultMatrixdADDRESS = null;

        private static glShadeModelPROC glShadeModelADDRESS = null;

        private static glSelectBufferPROC glSelectBufferADDRESS = null;

        private static glScissorPROC glScissorADDRESS = null;

        private static glScalefPROC glScalefADDRESS = null;

        private static glScaledPROC glScaledADDRESS = null;

        private static glRotatefPROC glRotatefADDRESS = null;

        private static glRenderModePROC glRenderModeADDRESS = null;

        private static glRectfPROC glRectfADDRESS = null;

        private static glRectdPROC glRectdADDRESS = null;

        private static glRectiPROC glRectiADDRESS = null;

        private static glReadPixelsPROC glReadPixelsADDRESS = null;

        private static glReadBufferPROC glReadBufferADDRESS = null;

        private static glRasterPos2fPROC glRasterPos2fADDRESS = null;

        private static glRasterPos2dPROC glRasterPos2dADDRESS = null;

        private static glRasterPos2iPROC glRasterPos2iADDRESS = null;

        private static glRasterPos3fPROC glRasterPos3fADDRESS = null;

        private static glRasterPos3dPROC glRasterPos3dADDRESS = null;

        private static glRasterPos3iPROC glRasterPos3iADDRESS = null;

        private static glRasterPos4fPROC glRasterPos4fADDRESS = null;

        private static glRasterPos4dPROC glRasterPos4dADDRESS = null;

        private static glRasterPos4iPROC glRasterPos4iADDRESS = null;

        private static glPushNamePROC glPushNameADDRESS = null;

        private static glPopNamePROC glPopNameADDRESS = null;

        private static glPushMatrixPROC glPushMatrixADDRESS = null;

        private static glPopMatrixPROC glPopMatrixADDRESS = null;

        private static glPushClientAttribPROC glPushClientAttribADDRESS = null;

        private static glPopClientAttribPROC glPopClientAttribADDRESS = null;

        private static glPushAttribPROC glPushAttribADDRESS = null;

        private static glPopAttribPROC glPopAttribADDRESS = null;

        private static glStencilFuncPROC glStencilFuncADDRESS = null;

        private static glVertexPointerPROC glVertexPointerADDRESS = null;

        private static glVertex2fPROC glVertex2fADDRESS = null;

        private static glVertex2dPROC glVertex2dADDRESS = null;

        private static glVertex2iPROC glVertex2iADDRESS = null;

        private static glVertex3fPROC glVertex3fADDRESS = null;

        private static glVertex3dPROC glVertex3dADDRESS = null;

        private static glVertex3iPROC glVertex3iADDRESS = null;

        private static glVertex4fPROC glVertex4fADDRESS = null;

        private static glVertex4dPROC glVertex4dADDRESS = null;

        private static glVertex4iPROC glVertex4iADDRESS = null;

        private static glTranslatefPROC glTranslatefADDRESS = null;

        private static glTranslatedPROC glTranslatedADDRESS = null;

        private static glTexImage1DPROC glTexImage1DADDRESS = null;

        private static glTexImage2DPROC glTexImage2DADDRESS = null;

        private static glTexSubImage1DPROC glTexSubImage1DADDRESS = null;

        private static glTexSubImage2DPROC glTexSubImage2DADDRESS = null;

        private static glTexParameterfPROC glTexParameterfADDRESS = null;

        private static glTexParameteriPROC glTexParameteriADDRESS = null;

        private static glTexParameterfvPROC glTexParameterfvADDRESS = null;

        private static glTexParameterivPROC glTexParameterivADDRESS = null;

        private static glTexGenfPROC glTexGenfADDRESS = null;

        private static glTexGendPROC glTexGendADDRESS = null;

        private static glTexGenfvPROC glTexGenfvADDRESS = null;

        private static glTexGendvPROC glTexGendvADDRESS = null;

        private static glTexGeniPROC glTexGeniADDRESS = null;

        private static glTexGenivPROC glTexGenivADDRESS = null;

        private static glTexEnvfPROC glTexEnvfADDRESS = null;

        private static glTexEnviPROC glTexEnviADDRESS = null;

        private static glTexEnvfvPROC glTexEnvfvADDRESS = null;

        private static glTexEnvivPROC glTexEnvivADDRESS = null;

        private static glTexCoordPointerPROC glTexCoordPointerADDRESS = null;

        private static glTexCoord1fPROC glTexCoord1fADDRESS = null;

        private static glTexCoord1dPROC glTexCoord1dADDRESS = null;

        private static glTexCoord2fPROC glTexCoord2fADDRESS = null;

        private static glTexCoord2dPROC glTexCoord2dADDRESS = null;

        private static glTexCoord3fPROC glTexCoord3fADDRESS = null;

        private static glTexCoord3dPROC glTexCoord3dADDRESS = null;

        private static glTexCoord4fPROC glTexCoord4fADDRESS = null;

        private static glTexCoord4dPROC glTexCoord4dADDRESS = null;

        private static glStencilOpPROC glStencilOpADDRESS = null;

        private static glStencilMaskPROC glStencilMaskADDRESS = null;

        private static glViewportPROC glViewportADDRESS = null;

        #endregion
        #region OpenGL X.X functions
        public static void glAccum(uint op, float value) {
            if (glAccumADDRESS != null) {
                glAccumADDRESS(op, value);
                return;
            }
            glAccumPROCF(op, value);
        }

        public static void glAlphaFunc(uint func, float ref_) {
            if (glAlphaFuncADDRESS != null) {
                glAlphaFuncADDRESS(func, ref_);
                return;
            }
            glAlphaFuncPROCF(func, ref_);
        }

        public static void glClearColor(float red, float green, float blue, float alpha) {
            if (glClearColorADDRESS != null) {
                glClearColorADDRESS(red, green, blue, alpha);
                return;
            }
            glClearColorPROCF(red, green, blue, alpha);
        }

        public static void glClearAccum(float red, float green, float blue, float alpha) {
            if (glClearAccumADDRESS != null) {
                glClearAccumADDRESS(red, green, blue, alpha);
                return;
            }
            glClearAccumPROCF(red, green, blue, alpha);
        }

        public static void glClear(uint mask) {
            if (glClearADDRESS != null) {
                glClearADDRESS(mask);
                return;
            }
            glClearPROCF(mask);
        }

        public static void glCallLists(int n, uint type, void* lists) {
            if (glCallListsADDRESS != null) {
                glCallListsADDRESS(n, type, lists);
                return;
            }
            glCallListsPROCF(n, type, lists);
        }

        public static void glCallList(uint list) {
            if (glCallListADDRESS != null) {
                glCallListADDRESS(list);
                return;
            }
            glCallListPROCF(list);
        }

        public static void glBlendFunc(uint sfactor, uint dfactor) {
            if (glBlendFuncADDRESS != null) {
                glBlendFuncADDRESS(sfactor, dfactor);
                return;
            }
            glBlendFuncPROCF(sfactor, dfactor);
        }

        public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) {
            if (glBitmapADDRESS != null) {
                glBitmapADDRESS(width, height, xorig, yorig, xmove, ymove, bitmap);
                return;
            }
            glBitmapPROCF(width, height, xorig, yorig, xmove, ymove, bitmap);
        }

        public static void glBindTexture(uint target, uint texture) {
            if (glBindTextureADDRESS != null) {
                glBindTextureADDRESS(target, texture);
                return;
            }
            glBindTexturePROCF(target, texture);
        }

        public static void glPrioritizeTextures(int n, uint* textures, float* priorities) {
            if (glPrioritizeTexturesADDRESS != null) {
                glPrioritizeTexturesADDRESS(n, textures, priorities);
                return;
            }
            glPrioritizeTexturesPROCF(n, textures, priorities);
        }

        public static bool glAreTexturesResident(int n, uint* textures, bool* residences) {
            if (glAreTexturesResidentADDRESS != null)
                return glAreTexturesResidentADDRESS(n, textures, residences);
            return glAreTexturesResidentPROCF(n, textures, residences);
        }

        public static void glBegin(uint mode) {
            if (glBeginADDRESS != null) {
                glBeginADDRESS(mode);
                return;
            }
            glBeginPROCF(mode);
        }

        public static void glEnd() {
            if (glEndADDRESS != null) {
                glEndADDRESS();
                return;
            }
            glEndPROCF();
        }

        public static void glArrayElement(int i) {
            if (glArrayElementADDRESS != null) {
                glArrayElementADDRESS(i);
                return;
            }
            glArrayElementPROCF(i);
        }

        public static void glClearDepth(double depth) {
            if (glClearDepthADDRESS != null) {
                glClearDepthADDRESS(depth);
                return;
            }
            glClearDepthPROCF(depth);
        }

        public static void glDeleteLists(uint list, int range) {
            if (glDeleteListsADDRESS != null) {
                glDeleteListsADDRESS(list, range);
                return;
            }
            glDeleteListsPROCF(list, range);
        }

        public static void glDeleteTextures(int n, uint* textures) {
            if (glDeleteTexturesADDRESS != null) {
                glDeleteTexturesADDRESS(n, textures);
                return;
            }
            glDeleteTexturesPROCF(n, textures);
        }

        public static void glCullFace(uint mode) {
            if (glCullFaceADDRESS != null) {
                glCullFaceADDRESS(mode);
                return;
            }
            glCullFacePROCF(mode);
        }

        public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
            if (glCopyTexSubImage2DADDRESS != null) {
                glCopyTexSubImage2DADDRESS(target, level, xoffset, yoffset, x, y, width, height);
                return;
            }
            glCopyTexSubImage2DPROCF(target, level, xoffset, yoffset, x, y, width, height);
        }

        public static void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) {
            if (glCopyTexSubImage1DADDRESS != null) {
                glCopyTexSubImage1DADDRESS(target, level, xoffset, x, y, width);
                return;
            }
            glCopyTexSubImage1DPROCF(target, level, xoffset, x, y, width);
        }

        public static void glCopyTexImage2D(uint target, int level, int internalFormat, int x, int y, int width, int height, int border) {
            if (glCopyTexImage2DADDRESS != null) {
                glCopyTexImage2DADDRESS(target, level, internalFormat, x, y, width, height, border);
                return;
            }
            glCopyTexImage2DPROCF(target, level, internalFormat, x, y, width, height, border);
        }

        public static void glCopyTexImage1D(uint target, int level, int internalFormat, int x, int y, int width, int border) {
            if (glCopyTexImage1DADDRESS != null) {
                glCopyTexImage1DADDRESS(target, level, internalFormat, x, y, width, border);
                return;
            }
            glCopyTexImage1DPROCF(target, level, internalFormat, x, y, width, border);
        }

        public static void glCopyPixels(int x, int y, int width, int height, int type) {
            if (glCopyPixelsADDRESS != null) {
                glCopyPixelsADDRESS(x, y, width, height, type);
                return;
            }
            glCopyPixelsPROCF(x, y, width, height, type);
        }

        public static void glColorPointer(int size, uint type, int stride, void* pointer) {
            if (glColorPointerADDRESS != null) {
                glColorPointerADDRESS(size, type, stride, pointer);
                return;
            }
            glColorPointerPROCF(size, type, stride, pointer);
        }

        public static void glColorMaterial(uint face, uint mode) {
            if (glColorMaterialADDRESS != null) {
                glColorMaterialADDRESS(face, mode);
                return;
            }
            glColorMaterialPROCF(face, mode);
        }

        public static void glColorMask(bool red, bool green, bool blue, bool alpha) {
            if (glColorMaskADDRESS != null) {
                glColorMaskADDRESS(red, green, blue, alpha);
                return;
            }
            glColorMaskPROCF(red, green, blue, alpha);
        }

        public static void glColor3b(byte red, byte green, byte blue) {
            if (glColor3bADDRESS != null) {
                glColor3bADDRESS(red, green, blue);
                return;
            }
            glColor3bPROCF(red, green, blue);
        }

        public static void glColor3f(float red, float green, float blue) {
            if (glColor3fADDRESS != null) {
                glColor3fADDRESS(red, green, blue);
                return;
            }
            glColor3fPROCF(red, green, blue);
        }

        public static void glColor3d(double red, double green, double blue) {
            if (glColor3dADDRESS != null) {
                glColor3dADDRESS(red, green, blue);
                return;
            }
            glColor3dPROCF(red, green, blue);
        }

        public static void glColor3ub(byte red, byte green, byte blue) {
            if (glColor3ubADDRESS != null) {
                glColor3ubADDRESS(red, green, blue);
                return;
            }
            glColor3ubPROCF(red, green, blue);
        }

        public static void glColor4b(byte red, byte green, byte blue, byte alpha) {
            if (glColor4bADDRESS != null) {
                glColor4bADDRESS(red, green, blue, alpha);
                return;
            }
            glColor4bPROCF(red, green, blue, alpha);
        }

        public static void glColor4f(float red, float green, float blue, float alpha) {
            if (glColor4fADDRESS != null) {
                glColor4fADDRESS(red, green, blue, alpha);
                return;
            }
            glColor4fPROCF(red, green, blue, alpha);
        }

        public static void glColor4d(double red, double green, double blue, double alpha) {
            if (glColor4dADDRESS != null) {
                glColor4dADDRESS(red, green, blue, alpha);
                return;
            }
            glColor4dPROCF(red, green, blue, alpha);
        }

        public static void glColor4ub(byte red, byte green, byte blue, byte alpha) {
            if (glColor4ubADDRESS != null) {
                glColor4ubADDRESS(red, green, blue, alpha);
                return;
            }
            glColor4ubPROCF(red, green, blue, alpha);
        }

        public static void glClipPlane(uint plane, double* equation) {
            if (glClipPlaneADDRESS != null) {
                glClipPlaneADDRESS(plane, equation);
                return;
            }
            glClipPlanePROCF(plane, equation);
        }

        public static void glClearStencil(int s) {
            if (glClearStencilADDRESS != null) {
                glClearStencilADDRESS(s);
                return;
            }
            glClearStencilPROCF(s);
        }

        public static void glEvalPoint1(int i) {
            if (glEvalPoint1ADDRESS != null) {
                glEvalPoint1ADDRESS(i);
                return;
            }
            glEvalPoint1PROCF(i);
        }

        public static void glEvalPoint2(int i, int j) {
            if (glEvalPoint2ADDRESS != null) {
                glEvalPoint2ADDRESS(i, j);
                return;
            }
            glEvalPoint2PROCF(i, j);
        }

        public static void glEvalMesh1(uint mode, int i1, int i2) {
            if (glEvalMesh1ADDRESS != null) {
                glEvalMesh1ADDRESS(mode, i1, i2);
                return;
            }
            glEvalMesh1PROCF(mode, i1, i2);
        }

        public static void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2) {
            if (glEvalMesh2ADDRESS != null) {
                glEvalMesh2ADDRESS(mode, i1, i2, j1, j2);
                return;
            }
            glEvalMesh2PROCF(mode, i1, i2, j1, j2);
        }

        public static void glEvalCoord1f(float u) {
            if (glEvalCoord1fADDRESS != null) {
                glEvalCoord1fADDRESS(u);
                return;
            }
            glEvalCoord1fPROCF(u);
        }

        public static void glEvalCoord1d(double u) {
            if (glEvalCoord1dADDRESS != null) {
                glEvalCoord1dADDRESS(u);
                return;
            }
            glEvalCoord1dPROCF(u);
        }

        public static void glEvalCoord2f(float u, float v) {
            if (glEvalCoord2fADDRESS != null) {
                glEvalCoord2fADDRESS(u, v);
                return;
            }
            glEvalCoord2fPROCF(u, v);
        }

        public static void glEvalCoord2d(double u, double v) {
            if (glEvalCoord2dADDRESS != null) {
                glEvalCoord2dADDRESS(u, v);
                return;
            }
            glEvalCoord2dPROCF(u, v);
        }

        public static void glEnableClientState(uint cap) {
            if (glEnableClientStateADDRESS != null) {
                glEnableClientStateADDRESS(cap);
                return;
            }
            glEnableClientStatePROCF(cap);
        }

        public static void glDisableClientState(uint cap) {
            if (glDisableClientStateADDRESS != null) {
                glDisableClientStateADDRESS(cap);
                return;
            }
            glDisableClientStatePROCF(cap);
        }

        public static void glEnable(uint cap) {
            if (glEnableADDRESS != null) {
                glEnableADDRESS(cap);
                return;
            }
            glEnablePROCF(cap);
        }

        public static void glDisable(uint cap) {
            if (glDisableADDRESS != null) {
                glDisableADDRESS(cap);
                return;
            }
            glDisablePROCF(cap);
        }

        public static void glEdgeFlagPointer(int stride, void* pointer) {
            if (glEdgeFlagPointerADDRESS != null) {
                glEdgeFlagPointerADDRESS(stride, pointer);
                return;
            }
            glEdgeFlagPointerPROCF(stride, pointer);
        }

        public static void glEdgeFlag(byte flag) {
            if (glEdgeFlagADDRESS != null) {
                glEdgeFlagADDRESS(flag);
                return;
            }
            glEdgeFlagPROCF(flag);
        }

        public static void glDrawPixels(int width, int height, uint format, uint type, void* pixels) {
            if (glDrawPixelsADDRESS != null) {
                glDrawPixelsADDRESS(width, height, format, type, pixels);
                return;
            }
            glDrawPixelsPROCF(width, height, format, type, pixels);
        }

        public static void glDrawElements(uint mode, int count, uint type, void* indices) {
            if (glDrawElementsADDRESS != null) {
                glDrawElementsADDRESS(mode, count, type, indices);
                return;
            }
            glDrawElementsPROCF(mode, count, type, indices);
        }

        public static void glDrawBuffer(uint mode) {
            if (glDrawBufferADDRESS != null) {
                glDrawBufferADDRESS(mode);
                return;
            }
            glDrawBufferPROCF(mode);
        }

        public static void glDrawArrays(uint mode, int first, int count) {
            if (glDrawArraysADDRESS != null) {
                glDrawArraysADDRESS(mode, first, count);
                return;
            }
            glDrawArraysPROCF(mode, first, count);
        }

        public static void glDepthRange(double zNear, double zFar) {
            if (glDepthRangeADDRESS != null) {
                glDepthRangeADDRESS(zNear, zFar);
                return;
            }
            glDepthRangePROCF(zNear, zFar);
        }

        public static void glDepthMask(byte flag) {
            if (glDepthMaskADDRESS != null) {
                glDepthMaskADDRESS(flag);
                return;
            }
            glDepthMaskPROCF(flag);
        }

        public static void glDepthFunc(uint func) {
            if (glDepthFuncADDRESS != null) {
                glDepthFuncADDRESS(func);
                return;
            }
            glDepthFuncPROCF(func);
        }

        public static void glFeedbackBuffer(int size, uint type, float* buffer) {
            if (glFeedbackBufferADDRESS != null) {
                glFeedbackBufferADDRESS(size, type, buffer);
                return;
            }
            glFeedbackBufferPROCF(size, type, buffer);
        }

        public static void glGetPixelMapfv(uint map, float* values) {
            if (glGetPixelMapfvADDRESS != null) {
                glGetPixelMapfvADDRESS(map, values);
                return;
            }
            glGetPixelMapfvPROCF(map, values);
        }

        public static void glGetPixelMapuiv(uint map, uint* values) {
            if (glGetPixelMapuivADDRESS != null) {
                glGetPixelMapuivADDRESS(map, values);
                return;
            }
            glGetPixelMapuivPROCF(map, values);
        }

        public static void glGetPixelMapusv(uint map, ushort* values) {
            if (glGetPixelMapusvADDRESS != null) {
                glGetPixelMapusvADDRESS(map, values);
                return;
            }
            glGetPixelMapusvPROCF(map, values);
        }

        public static void glGetMaterialfv(uint face, uint pname, float* params_) {
            if (glGetMaterialfvADDRESS != null) {
                glGetMaterialfvADDRESS(face, pname, params_);
                return;
            }
            glGetMaterialfvPROCF(face, pname, params_);
        }

        public static void glGetMaterialiv(uint face, uint pname, int* params_) {
            if (glGetMaterialivADDRESS != null) {
                glGetMaterialivADDRESS(face, pname, params_);
                return;
            }
            glGetMaterialivPROCF(face, pname, params_);
        }

        public static void glGetMapfv(uint target, uint query, float* v) {
            if (glGetMapfvADDRESS != null) {
                glGetMapfvADDRESS(target, query, v);
                return;
            }
            glGetMapfvPROCF(target, query, v);
        }

        public static void glGetMapdv(uint target, uint query, double* v) {
            if (glGetMapdvADDRESS != null) {
                glGetMapdvADDRESS(target, query, v);
                return;
            }
            glGetMapdvPROCF(target, query, v);
        }

        public static void glGetMapiv(uint target, uint query, int* v) {
            if (glGetMapivADDRESS != null) {
                glGetMapivADDRESS(target, query, v);
                return;
            }
            glGetMapivPROCF(target, query, v);
        }

        public static void glGetLightfv(uint light, uint pname, float* params_) {
            if (glGetLightfvADDRESS != null) {
                glGetLightfvADDRESS(light, pname, params_);
                return;
            }
            glGetLightfvPROCF(light, pname, params_);
        }

        public static void glGetLightiv(uint light, uint pname, int* params_) {
            if (glGetLightivADDRESS != null) {
                glGetLightivADDRESS(light, pname, params_);
                return;
            }
            glGetLightivPROCF(light, pname, params_);
        }

        public static int glGetError() {
            if (glGetErrorADDRESS != null)
                return glGetErrorADDRESS();
            return glGetErrorPROCF();
        }

        public static void glGetClipPlane(uint plane, double* equation) {
            if (glGetClipPlaneADDRESS != null) {
                glGetClipPlaneADDRESS(plane, equation);
                return;
            }
            glGetClipPlanePROCF(plane, equation);
        }

        public static void glGetBooleanv(uint pname, bool* params_) {
            if (glGetBooleanvADDRESS != null) {
                glGetBooleanvADDRESS(pname, params_);
                return;
            }
            glGetBooleanvPROCF(pname, params_);
        }

        public static void glGetDoublev(uint pname, double* params_) {
            if (glGetDoublevADDRESS != null) {
                glGetDoublevADDRESS(pname, params_);
                return;
            }
            glGetDoublevPROCF(pname, params_);
        }

        public static void glGetFloatv(uint pname, float* params_) {
            if (glGetFloatvADDRESS != null) {
                glGetFloatvADDRESS(pname, params_);
                return;
            }
            glGetFloatvPROCF(pname, params_);
        }

        public static void glGetIntegerv(uint pname, int* params_) {
            if (glGetIntegervADDRESS != null) {
                glGetIntegervADDRESS(pname, params_);
                return;
            }
            glGetIntegervPROCF(pname, params_);
        }

        public static void glGenTextures(int n, uint* textures) {
            if (glGenTexturesADDRESS != null) {
                glGenTexturesADDRESS(n, textures);
                return;
            }
            glGenTexturesPROCF(n, textures);
        }

        public static uint glGenLists(int range) {
            if (glGenListsADDRESS != null)
                return glGenListsADDRESS(range);
            return glGenListsPROCF(range);
        }

        public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) {
            if (glFrustumADDRESS != null) {
                glFrustumADDRESS(left, right, bottom, top, zNear, zFar);
                return;
            }
            glFrustumPROCF(left, right, bottom, top, zNear, zFar);
        }

        public static void glFrontFace(uint mode) {
            if (glFrontFaceADDRESS != null) {
                glFrontFaceADDRESS(mode);
                return;
            }
            glFrontFacePROCF(mode);
        }

        public static void glFogf(uint pname, float param) {
            if (glFogfADDRESS != null) {
                glFogfADDRESS(pname, param);
                return;
            }
            glFogfPROCF(pname, param);
        }

        public static void glFogi(uint pname, int param) {
            if (glFogiADDRESS != null) {
                glFogiADDRESS(pname, param);
                return;
            }
            glFogiPROCF(pname, param);
        }

        public static void glFogfv(uint pname, float* params_) {
            if (glFogfvADDRESS != null) {
                glFogfvADDRESS(pname, params_);
                return;
            }
            glFogfvPROCF(pname, params_);
        }

        public static void glFogiv(uint pname, int* params_) {
            if (glFogivADDRESS != null) {
                glFogivADDRESS(pname, params_);
                return;
            }
            glFogivPROCF(pname, params_);
        }

        public static void glFlush() {
            if (glFlushADDRESS != null) {
                glFlushADDRESS();
                return;
            }
            glFlushPROCF();
        }

        public static void glFinish() {
            if (glFinishADDRESS != null) {
                glFinishADDRESS();
                return;
            }
            glFinishPROCF();
        }

        public static void glGetPointerv(uint pname, void** result) {
            if (glGetPointervADDRESS != null) {
                glGetPointervADDRESS(pname, result);
                return;
            }
            glGetPointervPROCF(pname, result);
        }

        public static bool glIsEnabled(uint cap) {
            if (glIsEnabledADDRESS != null)
                return glIsEnabledADDRESS(cap);
            return glIsEnabledPROCF(cap);
        }

        public static void glInterleavedArrays(uint format, int stride, void* pointer) {
            if (glInterleavedArraysADDRESS != null) {
                glInterleavedArraysADDRESS(format, stride, pointer);
                return;
            }
            glInterleavedArraysPROCF(format, stride, pointer);
        }

        public static void glInitNames() {
            if (glInitNamesADDRESS != null) {
                glInitNamesADDRESS();
                return;
            }
            glInitNamesPROCF();
        }

        public static void glHint(uint target, uint mode) {
            if (glHintADDRESS != null) {
                glHintADDRESS(target, mode);
                return;
            }
            glHintPROCF(target, mode);
        }

        public static void glGetTexParameterfv(uint target, uint pname, float* params_) {
            if (glGetTexParameterfvADDRESS != null) {
                glGetTexParameterfvADDRESS(target, pname, params_);
                return;
            }
            glGetTexParameterfvPROCF(target, pname, params_);
        }

        public static void glGetTexParameteriv(uint target, uint pname, int* params_) {
            if (glGetTexParameterivADDRESS != null) {
                glGetTexParameterivADDRESS(target, pname, params_);
                return;
            }
            glGetTexParameterivPROCF(target, pname, params_);
        }

        public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float* params_) {
            if (glGetTexLevelParameterfvADDRESS != null) {
                glGetTexLevelParameterfvADDRESS(target, level, pname, params_);
                return;
            }
            glGetTexLevelParameterfvPROCF(target, level, pname, params_);
        }

        public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int* params_) {
            if (glGetTexLevelParameterivADDRESS != null) {
                glGetTexLevelParameterivADDRESS(target, level, pname, params_);
                return;
            }
            glGetTexLevelParameterivPROCF(target, level, pname, params_);
        }

        public static void glGetTexImage(uint target, int level, uint format, uint type, void* pixels) {
            if (glGetTexImageADDRESS != null) {
                glGetTexImageADDRESS(target, level, format, type, pixels);
                return;
            }
            glGetTexImagePROCF(target, level, format, type, pixels);
        }

        public static void glGetTexGeniv(uint coord, uint pname, int* params_) {
            if (glGetTexGenivADDRESS != null) {
                glGetTexGenivADDRESS(coord, pname, params_);
                return;
            }
            glGetTexGenivPROCF(coord, pname, params_);
        }

        public static void glGetTexGenfv(uint coord, uint pname, float* params_) {
            if (glGetTexGenfvADDRESS != null) {
                glGetTexGenfvADDRESS(coord, pname, params_);
                return;
            }
            glGetTexGenfvPROCF(coord, pname, params_);
        }

        public static void glGetTexGendv(uint coord, uint pname, double* params_) {
            if (glGetTexGendvADDRESS != null) {
                glGetTexGendvADDRESS(coord, pname, params_);
                return;
            }
            glGetTexGendvPROCF(coord, pname, params_);
        }

        public static void glGetTexEnviv(uint coord, uint pname, int* params_) {
            if (glGetTexEnvivADDRESS != null) {
                glGetTexEnvivADDRESS(coord, pname, params_);
                return;
            }
            glGetTexEnvivPROCF(coord, pname, params_);
        }

        public static void glGetTexEnvfv(uint coord, uint pname, float* params_) {
            if (glGetTexEnvfvADDRESS != null) {
                glGetTexEnvfvADDRESS(coord, pname, params_);
                return;
            }
            glGetTexEnvfvPROCF(coord, pname, params_);
        }

        public static byte* glGetString(int name) {
            if (glGetStringADDRESS != null)
                return glGetStringADDRESS(name);
            return glGetStringPROCF(name);
        }

        public static void glGetPolygonStipple(byte* mask) {
            if (glGetPolygonStippleADDRESS != null) {
                glGetPolygonStippleADDRESS(mask);
                return;
            }
            glGetPolygonStipplePROCF(mask);
        }

        public static bool glIsList(uint list) {
            if (glIsListADDRESS != null)
                return glIsListADDRESS(list);
            return glIsListPROCF(list);
        }

        public static void glMaterialf(uint face, uint pname, float param) {
            if (glMaterialfADDRESS != null) {
                glMaterialfADDRESS(face, pname, param);
                return;
            }
            glMaterialfPROCF(face, pname, param);
        }

        public static void glMateriali(uint face, uint pname, int param) {
            if (glMaterialiADDRESS != null) {
                glMaterialiADDRESS(face, pname, param);
                return;
            }
            glMaterialiPROCF(face, pname, param);
        }

        public static void glMaterialfv(uint face, uint pname, float* params_) {
            if (glMaterialfvADDRESS != null) {
                glMaterialfvADDRESS(face, pname, params_);
                return;
            }
            glMaterialfvPROCF(face, pname, params_);
        }

        public static void glMaterialiv(uint face, uint pname, int* params_) {
            if (glMaterialivADDRESS != null) {
                glMaterialivADDRESS(face, pname, params_);
                return;
            }
            glMaterialivPROCF(face, pname, params_);
        }

        public static void glMapGrid1f(int un, float u1, float u2) {
            if (glMapGrid1fADDRESS != null) {
                glMapGrid1fADDRESS(un, u1, u2);
                return;
            }
            glMapGrid1fPROCF(un, u1, u2);
        }

        public static void glMapGrid1d(int un, double u1, double u2) {
            if (glMapGrid1dADDRESS != null) {
                glMapGrid1dADDRESS(un, u1, u2);
                return;
            }
            glMapGrid1dPROCF(un, u1, u2);
        }

        public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) {
            if (glMapGrid2fADDRESS != null) {
                glMapGrid2fADDRESS(un, u1, u2, vn, v1, v2);
                return;
            }
            glMapGrid2fPROCF(un, u1, u2, vn, v1, v2);
        }

        public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) {
            if (glMapGrid2dADDRESS != null) {
                glMapGrid2dADDRESS(un, u1, u2, vn, v1, v2);
                return;
            }
            glMapGrid2dPROCF(un, u1, u2, vn, v1, v2);
        }

        public static void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) {
            if (glMap2fADDRESS != null) {
                glMap2fADDRESS(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
                return;
            }
            glMap2fPROCF(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }

        public static void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) {
            if (glMap2dADDRESS != null) {
                glMap2dADDRESS(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
                return;
            }
            glMap2dPROCF(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }

        public static void glMap1f(uint target, float u1, float u2, int stride, int order, float* points) {
            if (glMap1fADDRESS != null) {
                glMap1fADDRESS(target, u1, u2, stride, order, points);
                return;
            }
            glMap1fPROCF(target, u1, u2, stride, order, points);
        }

        public static void glMap1d(uint target, double u1, double u2, int stride, int order, double* points) {
            if (glMap1dADDRESS != null) {
                glMap1dADDRESS(target, u1, u2, stride, order, points);
                return;
            }
            glMap1dPROCF(target, u1, u2, stride, order, points);
        }

        public static void glLogicOp(uint opcode) {
            if (glLogicOpADDRESS != null) {
                glLogicOpADDRESS(opcode);
                return;
            }
            glLogicOpPROCF(opcode);
        }

        public static void glLoadName(uint name) {
            if (glLoadNameADDRESS != null) {
                glLoadNameADDRESS(name);
                return;
            }
            glLoadNamePROCF(name);
        }

        public static void glLoadMatrixf(float* m) {
            if (glLoadMatrixfADDRESS != null) {
                glLoadMatrixfADDRESS(m);
                return;
            }
            glLoadMatrixfPROCF(m);
        }

        public static void glLoadMatrixd(double* m) {
            if (glLoadMatrixdADDRESS != null) {
                glLoadMatrixdADDRESS(m);
                return;
            }
            glLoadMatrixdPROCF(m);
        }

        public static void glLoadIdentity() {
            if (glLoadIdentityADDRESS != null) {
                glLoadIdentityADDRESS();
                return;
            }
            glLoadIdentityPROCF();
        }

        public static void glListBase(uint base_) {
            if (glListBaseADDRESS != null) {
                glListBaseADDRESS(base_);
                return;
            }
            glListBasePROCF(base_);
        }

        public static void glLineWidth(float width) {
            if (glLineWidthADDRESS != null) {
                glLineWidthADDRESS(width);
                return;
            }
            glLineWidthPROCF(width);
        }

        public static void glLineStipple(int factor, ushort pattern) {
            if (glLineStippleADDRESS != null) {
                glLineStippleADDRESS(factor, pattern);
                return;
            }
            glLineStipplePROCF(factor, pattern);
        }

        public static void glLightModelf(uint pname, float param) {
            if (glLightModelfADDRESS != null) {
                glLightModelfADDRESS(pname, param);
                return;
            }
            glLightModelfPROCF(pname, param);
        }

        public static void glLightModeli(uint pname, int param) {
            if (glLightModeliADDRESS != null) {
                glLightModeliADDRESS(pname, param);
                return;
            }
            glLightModeliPROCF(pname, param);
        }

        public static void glLightModelfv(uint pname, float* params_) {
            if (glLightModelfvADDRESS != null) {
                glLightModelfvADDRESS(pname, params_);
                return;
            }
            glLightModelfvPROCF(pname, params_);
        }

        public static void glLightModeliv(uint pname, int* params_) {
            if (glLightModelivADDRESS != null) {
                glLightModelivADDRESS(pname, params_);
                return;
            }
            glLightModelivPROCF(pname, params_);
        }

        public static void glLightf(uint light, uint pname, float param) {
            if (glLightfADDRESS != null) {
                glLightfADDRESS(light, pname, param);
                return;
            }
            glLightfPROCF(light, pname, param);
        }

        public static void glLighti(uint light, uint pname, int param) {
            if (glLightiADDRESS != null) {
                glLightiADDRESS(light, pname, param);
                return;
            }
            glLightiPROCF(light, pname, param);
        }

        public static void glLightfv(uint light, uint pname, float* params_) {
            if (glLightfvADDRESS != null) {
                glLightfvADDRESS(light, pname, params_);
                return;
            }
            glLightfvPROCF(light, pname, params_);
        }

        public static void glLightiv(uint light, uint pname, int* params_) {
            if (glLightivADDRESS != null) {
                glLightivADDRESS(light, pname, params_);
                return;
            }
            glLightivPROCF(light, pname, params_);
        }

        public static bool glIsTexture(uint texture) {
            if (glIsTextureADDRESS != null)
                return glIsTextureADDRESS(texture);
            return glIsTexturePROCF(texture);
        }

        public static void glMatrixMode(uint mode) {
            if (glMatrixModeADDRESS != null) {
                glMatrixModeADDRESS(mode);
                return;
            }
            glMatrixModePROCF(mode);
        }

        public static void glPolygonStipple(byte* mask) {
            if (glPolygonStippleADDRESS != null) {
                glPolygonStippleADDRESS(mask);
                return;
            }
            glPolygonStipplePROCF(mask);
        }

        public static void glPolygonOffset(float factor, float units) {
            if (glPolygonOffsetADDRESS != null) {
                glPolygonOffsetADDRESS(factor, units);
                return;
            }
            glPolygonOffsetPROCF(factor, units);
        }

        public static void glPolygonMode(uint face, uint mode) {
            if (glPolygonModeADDRESS != null) {
                glPolygonModeADDRESS(face, mode);
                return;
            }
            glPolygonModePROCF(face, mode);
        }

        public static void glPointSize(float size) {
            if (glPointSizeADDRESS != null) {
                glPointSizeADDRESS(size);
                return;
            }
            glPointSizePROCF(size);
        }

        public static void glPixelZoom(float xfactor, float yfactor) {
            if (glPixelZoomADDRESS != null) {
                glPixelZoomADDRESS(xfactor, yfactor);
                return;
            }
            glPixelZoomPROCF(xfactor, yfactor);
        }

        public static void glPixelTransferf(uint pname, float param) {
            if (glPixelTransferfADDRESS != null) {
                glPixelTransferfADDRESS(pname, param);
                return;
            }
            glPixelTransferfPROCF(pname, param);
        }

        public static void glPixelTransferi(uint pname, int param) {
            if (glPixelTransferiADDRESS != null) {
                glPixelTransferiADDRESS(pname, param);
                return;
            }
            glPixelTransferiPROCF(pname, param);
        }

        public static void glPixelStoref(uint pname, float param) {
            if (glPixelStorefADDRESS != null) {
                glPixelStorefADDRESS(pname, param);
                return;
            }
            glPixelStorefPROCF(pname, param);
        }

        public static void glPixelStorei(uint pname, int param) {
            if (glPixelStoreiADDRESS != null) {
                glPixelStoreiADDRESS(pname, param);
                return;
            }
            glPixelStoreiPROCF(pname, param);
        }

        public static void glPixelMapfv(uint map, int mapsize, float* values) {
            if (glPixelMapfvADDRESS != null) {
                glPixelMapfvADDRESS(map, mapsize, values);
                return;
            }
            glPixelMapfvPROCF(map, mapsize, values);
        }

        public static void glPixelMapuiv(uint map, int mapsize, uint* values) {
            if (glPixelMapuivADDRESS != null) {
                glPixelMapuivADDRESS(map, mapsize, values);
                return;
            }
            glPixelMapuivPROCF(map, mapsize, values);
        }

        public static void glPixelMapusv(uint map, int mapsize, ushort* values) {
            if (glPixelMapusvADDRESS != null) {
                glPixelMapusvADDRESS(map, mapsize, values);
                return;
            }
            glPixelMapusvPROCF(map, mapsize, values);
        }

        public static void glPassThrough(float token) {
            if (glPassThroughADDRESS != null) {
                glPassThroughADDRESS(token);
                return;
            }
            glPassThroughPROCF(token);
        }

        public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) {
            if (glOrthoADDRESS != null) {
                glOrthoADDRESS(left, right, bottom, top, zNear, zFar);
                return;
            }
            glOrthoPROCF(left, right, bottom, top, zNear, zFar);
        }

        public static void glNormalPointer(uint type, int stride, void* pointer) {
            if (glNormalPointerADDRESS != null) {
                glNormalPointerADDRESS(type, stride, pointer);
                return;
            }
            glNormalPointerPROCF(type, stride, pointer);
        }

        public static void glNormal3b(byte nx, byte ny, byte nz) {
            if (glNormal3bADDRESS != null) {
                glNormal3bADDRESS(nx, ny, nz);
                return;
            }
            glNormal3bPROCF(nx, ny, nz);
        }

        public static void glNormal3f(float nx, float ny, float nz) {
            if (glNormal3fADDRESS != null) {
                glNormal3fADDRESS(nx, ny, nz);
                return;
            }
            glNormal3fPROCF(nx, ny, nz);
        }

        public static void glNormal3d(double nx, double ny, double nz) {
            if (glNormal3dADDRESS != null) {
                glNormal3dADDRESS(nx, ny, nz);
                return;
            }
            glNormal3dPROCF(nx, ny, nz);
        }

        public static void glNormal3i(int nx, int ny, int nz) {
            if (glNormal3iADDRESS != null) {
                glNormal3iADDRESS(nx, ny, nz);
                return;
            }
            glNormal3iPROCF(nx, ny, nz);
        }

        public static void glNewList(uint list, uint mode) {
            if (glNewListADDRESS != null) {
                glNewListADDRESS(list, mode);
                return;
            }
            glNewListPROCF(list, mode);
        }

        public static void glEndList() {
            if (glEndListADDRESS != null) {
                glEndListADDRESS();
                return;
            }
            glEndListPROCF();
        }

        public static void glMultMatrixf(float* m) {
            if (glMultMatrixfADDRESS != null) {
                glMultMatrixfADDRESS(m);
                return;
            }
            glMultMatrixfPROCF(m);
        }

        public static void glMultMatrixd(double* m) {
            if (glMultMatrixdADDRESS != null) {
                glMultMatrixdADDRESS(m);
                return;
            }
            glMultMatrixdPROCF(m);
        }

        public static void glShadeModel(uint mode) {
            if (glShadeModelADDRESS != null) {
                glShadeModelADDRESS(mode);
                return;
            }
            glShadeModelPROCF(mode);
        }

        public static void glSelectBuffer(int size, uint* buffer) {
            if (glSelectBufferADDRESS != null) {
                glSelectBufferADDRESS(size, buffer);
                return;
            }
            glSelectBufferPROCF(size, buffer);
        }

        public static void glScissor(int x, int y, int width, int height) {
            if (glScissorADDRESS != null) {
                glScissorADDRESS(x, y, width, height);
                return;
            }
            glScissorPROCF(x, y, width, height);
        }

        public static void glScalef(float x, float y, float z) {
            if (glScalefADDRESS != null) {
                glScalefADDRESS(x, y, z);
                return;
            }
            glScalefPROCF(x, y, z);
        }

        public static void glScaled(double x, double y, double z) {
            if (glScaledADDRESS != null) {
                glScaledADDRESS(x, y, z);
                return;
            }
            glScaledPROCF(x, y, z);
        }

        public static void glRotatef(float angle, float x, float y, float z) {
            if (glRotatefADDRESS != null) {
                glRotatefADDRESS(angle, x, y, z);
                return;
            }
            glRotatefPROCF(angle, x, y, z);
        }

        public static int glRenderMode(uint mode) {
            if (glRenderModeADDRESS != null)
                return glRenderModeADDRESS(mode);
            return glRenderModePROCF(mode);
        }

        public static void glRectf(float x1, float y1, float x2, float y2) {
            if (glRectfADDRESS != null) {
                glRectfADDRESS(x1, y1, x2, y2);
                return;
            }
            glRectfPROCF(x1, y1, x2, y2);
        }

        public static void glRectd(double x1, double y1, double x2, double y2) {
            if (glRectdADDRESS != null) {
                glRectdADDRESS(x1, y1, x2, y2);
                return;
            }
            glRectdPROCF(x1, y1, x2, y2);
        }

        public static void glRecti(int x1, int y1, int x2, int y2) {
            if (glRectiADDRESS != null) {
                glRectiADDRESS(x1, y1, x2, y2);
                return;
            }
            glRectiPROCF(x1, y1, x2, y2);
        }

        public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) {
            if (glReadPixelsADDRESS != null) {
                glReadPixelsADDRESS(x, y, width, height, format, type, pixels);
                return;
            }
            glReadPixelsPROCF(x, y, width, height, format, type, pixels);
        }

        public static void glReadBuffer(uint mode) {
            if (glReadBufferADDRESS != null) {
                glReadBufferADDRESS(mode);
                return;
            }
            glReadBufferPROCF(mode);
        }

        public static void glRasterPos2f(float x, float y) {
            if (glRasterPos2fADDRESS != null) {
                glRasterPos2fADDRESS(x, y);
                return;
            }
            glRasterPos2fPROCF(x, y);
        }

        public static void glRasterPos2d(double x, double y) {
            if (glRasterPos2dADDRESS != null) {
                glRasterPos2dADDRESS(x, y);
                return;
            }
            glRasterPos2dPROCF(x, y);
        }

        public static void glRasterPos2i(int x, int y) {
            if (glRasterPos2iADDRESS != null) {
                glRasterPos2iADDRESS(x, y);
                return;
            }
            glRasterPos2iPROCF(x, y);
        }

        public static void glRasterPos3f(float x, float y, float z) {
            if (glRasterPos3fADDRESS != null) {
                glRasterPos3fADDRESS(x, y, z);
                return;
            }
            glRasterPos3fPROCF(x, y, z);
        }

        public static void glRasterPos3d(double x, double y, double z) {
            if (glRasterPos3dADDRESS != null) {
                glRasterPos3dADDRESS(x, y, z);
                return;
            }
            glRasterPos3dPROCF(x, y, z);
        }

        public static void glRasterPos3i(int x, int y, int z) {
            if (glRasterPos3iADDRESS != null) {
                glRasterPos3iADDRESS(x, y, z);
                return;
            }
            glRasterPos3iPROCF(x, y, z);
        }

        public static void glRasterPos4f(float x, float y, float z, float w) {
            if (glRasterPos4fADDRESS != null) {
                glRasterPos4fADDRESS(x, y, z, w);
                return;
            }
            glRasterPos4fPROCF(x, y, z, w);
        }

        public static void glRasterPos4d(double x, double y, double z, double w) {
            if (glRasterPos4dADDRESS != null) {
                glRasterPos4dADDRESS(x, y, z, w);
                return;
            }
            glRasterPos4dPROCF(x, y, z, w);
        }

        public static void glRasterPos4i(int x, int y, int z, int w) {
            if (glRasterPos4iADDRESS != null) {
                glRasterPos4iADDRESS(x, y, z, w);
                return;
            }
            glRasterPos4iPROCF(x, y, z, w);
        }

        public static void glPushName(uint name) {
            if (glPushNameADDRESS != null) {
                glPushNameADDRESS(name);
                return;
            }
            glPushNamePROCF(name);
        }

        public static void glPopName() {
            if (glPopNameADDRESS != null) {
                glPopNameADDRESS();
                return;
            }
            glPopNamePROCF();
        }

        public static void glPushMatrix() {
            if (glPushMatrixADDRESS != null) {
                glPushMatrixADDRESS();
                return;
            }
            glPushMatrixPROCF();
        }

        public static void glPopMatrix() {
            if (glPopMatrixADDRESS != null) {
                glPopMatrixADDRESS();
                return;
            }
            glPopMatrixPROCF();
        }

        public static void glPushClientAttrib(uint mask) {
            if (glPushClientAttribADDRESS != null) {
                glPushClientAttribADDRESS(mask);
                return;
            }
            glPushClientAttribPROCF(mask);
        }

        public static void glPopClientAttrib() {
            if (glPopClientAttribADDRESS != null) {
                glPopClientAttribADDRESS();
                return;
            }
            glPopClientAttribPROCF();
        }

        public static void glPushAttrib(uint mask) {
            if (glPushAttribADDRESS != null) {
                glPushAttribADDRESS(mask);
                return;
            }
            glPushAttribPROCF(mask);
        }

        public static void glPopAttrib() {
            if (glPopAttribADDRESS != null) {
                glPopAttribADDRESS();
                return;
            }
            glPopAttribPROCF();
        }

        public static void glStencilFunc(uint func, int ref_, uint mask) {
            if (glStencilFuncADDRESS != null) {
                glStencilFuncADDRESS(func, ref_, mask);
                return;
            }
            glStencilFuncPROCF(func, ref_, mask);
        }

        public static void glVertexPointer(int size, uint type, int stride, void* pointer) {
            if (glVertexPointerADDRESS != null) {
                glVertexPointerADDRESS(size, type, stride, pointer);
                return;
            }
            glVertexPointerPROCF(size, type, stride, pointer);
        }

        public static void glVertex2f(float x, float y) {
            if (glVertex2fADDRESS != null) {
                glVertex2fADDRESS(x, y);
                return;
            }
            glVertex2fPROCF(x, y);
        }

        public static void glVertex2d(double x, double y) {
            if (glVertex2dADDRESS != null) {
                glVertex2dADDRESS(x, y);
                return;
            }
            glVertex2dPROCF(x, y);
        }

        public static void glVertex2i(int x, int y) {
            if (glVertex2iADDRESS != null) {
                glVertex2iADDRESS(x, y);
                return;
            }
            glVertex2iPROCF(x, y);
        }

        public static void glVertex3f(float x, float y, float z) {
            if (glVertex3fADDRESS != null) {
                glVertex3fADDRESS(x, y, z);
                return;
            }
            glVertex3fPROCF(x, y, z);
        }

        public static void glVertex3d(double x, double y, double z) {
            if (glVertex3dADDRESS != null) {
                glVertex3dADDRESS(x, y, z);
                return;
            }
            glVertex3dPROCF(x, y, z);
        }

        public static void glVertex3i(int x, int y, int z) {
            if (glVertex3iADDRESS != null) {
                glVertex3iADDRESS(x, y, z);
                return;
            }
            glVertex3iPROCF(x, y, z);
        }

        public static void glVertex4f(float x, float y, float z, float w) {
            if (glVertex4fADDRESS != null) {
                glVertex4fADDRESS(x, y, z, w);
                return;
            }
            glVertex4fPROCF(x, y, z, w);
        }

        public static void glVertex4d(double x, double y, double z, double w) {
            if (glVertex4dADDRESS != null) {
                glVertex4dADDRESS(x, y, z, w);
                return;
            }
            glVertex4dPROCF(x, y, z, w);
        }

        public static void glVertex4i(int x, int y, int z, int w) {
            if (glVertex4iADDRESS != null) {
                glVertex4iADDRESS(x, y, z, w);
                return;
            }
            glVertex4iPROCF(x, y, z, w);
        }

        public static void glTranslatef(float x, float y, float z) {
            if (glTranslatefADDRESS != null) {
                glTranslatefADDRESS(x, y, z);
                return;
            }
            glTranslatefPROCF(x, y, z);
        }

        public static void glTranslated(double x, double y, double z) {
            if (glTranslatedADDRESS != null) {
                glTranslatedADDRESS(x, y, z);
                return;
            }
            glTranslatedPROCF(x, y, z);
        }

        public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels) {
            if (glTexImage1DADDRESS != null) {
                glTexImage1DADDRESS(target, level, internalformat, width, border, format, type, pixels);
                return;
            }
            glTexImage1DPROCF(target, level, internalformat, width, border, format, type, pixels);
        }

        public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) {
            if (glTexImage2DADDRESS != null) {
                glTexImage2DADDRESS(target, level, internalformat, width, height, border, format, type, pixels);
                return;
            }
            glTexImage2DPROCF(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public static void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels) {
            if (glTexSubImage1DADDRESS != null) {
                glTexSubImage1DADDRESS(target, level, xoffset, width, format, type, pixels);
                return;
            }
            glTexSubImage1DPROCF(target, level, xoffset, width, format, type, pixels);
        }

        public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) {
            if (glTexSubImage2DADDRESS != null) {
                glTexSubImage2DADDRESS(target, level, xoffset, yoffset, width, height, format, type, pixels);
                return;
            }
            glTexSubImage2DPROCF(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public static void glTexParameterf(uint target, uint pname, float param) {
            if (glTexParameterfADDRESS != null) {
                glTexParameterfADDRESS(target, pname, param);
                return;
            }
            glTexParameterfPROCF(target, pname, param);
        }

        public static void glTexParameteri(uint target, uint pname, int param) {
            if (glTexParameteriADDRESS != null) {
                glTexParameteriADDRESS(target, pname, param);
                return;
            }
            glTexParameteriPROCF(target, pname, param);
        }

        public static void glTexParameterfv(uint target, uint pname, float* param) {
            if (glTexParameterfvADDRESS != null) {
                glTexParameterfvADDRESS(target, pname, param);
                return;
            }
            glTexParameterfvPROCF(target, pname, param);
        }

        public static void glTexParameteriv(uint target, uint pname, int* param) {
            if (glTexParameterivADDRESS != null) {
                glTexParameterivADDRESS(target, pname, param);
                return;
            }
            glTexParameterivPROCF(target, pname, param);
        }

        public static void glTexGenf(uint coord, uint pname, float param) {
            if (glTexGenfADDRESS != null) {
                glTexGenfADDRESS(coord, pname, param);
                return;
            }
            glTexGenfPROCF(coord, pname, param);
        }

        public static void glTexGend(uint coord, uint pname, double param) {
            if (glTexGendADDRESS != null) {
                glTexGendADDRESS(coord, pname, param);
                return;
            }
            glTexGendPROCF(coord, pname, param);
        }

        public static void glTexGenfv(uint coord, uint pname, float* params_) {
            if (glTexGenfvADDRESS != null) {
                glTexGenfvADDRESS(coord, pname, params_);
                return;
            }
            glTexGenfvPROCF(coord, pname, params_);
        }

        public static void glTexGendv(uint coord, uint pname, double* params_) {
            if (glTexGendvADDRESS != null) {
                glTexGendvADDRESS(coord, pname, params_);
                return;
            }
            glTexGendvPROCF(coord, pname, params_);
        }

        public static void glTexGeni(uint coord, uint pname, int param) {
            if (glTexGeniADDRESS != null) {
                glTexGeniADDRESS(coord, pname, param);
                return;
            }
            glTexGeniPROCF(coord, pname, param);
        }

        public static void glTexGeniv(uint coord, uint pname, int* params_) {
            if (glTexGenivADDRESS != null) {
                glTexGenivADDRESS(coord, pname, params_);
                return;
            }
            glTexGenivPROCF(coord, pname, params_);
        }

        public static void glTexEnvf(uint target, uint pname, float param) {
            if (glTexEnvfADDRESS != null) {
                glTexEnvfADDRESS(target, pname, param);
                return;
            }
            glTexEnvfPROCF(target, pname, param);
        }

        public static void glTexEnvi(uint target, uint pname, int param) {
            if (glTexEnviADDRESS != null) {
                glTexEnviADDRESS(target, pname, param);
                return;
            }
            glTexEnviPROCF(target, pname, param);
        }

        public static void glTexEnvfv(uint target, uint pname, float* params_) {
            if (glTexEnvfvADDRESS != null) {
                glTexEnvfvADDRESS(target, pname, params_);
                return;
            }
            glTexEnvfvPROCF(target, pname, params_);
        }

        public static void glTexEnviv(uint target, uint pname, int* params_) {
            if (glTexEnvivADDRESS != null) {
                glTexEnvivADDRESS(target, pname, params_);
                return;
            }
            glTexEnvivPROCF(target, pname, params_);
        }

        public static void glTexCoordPointer(int size, uint type, int stride, void* pointer) {
            if (glTexCoordPointerADDRESS != null) {
                glTexCoordPointerADDRESS(size, type, stride, pointer);
                return;
            }
            glTexCoordPointerPROCF(size, type, stride, pointer);
        }

        public static void glTexCoord1f(float s) {
            if (glTexCoord1fADDRESS != null) {
                glTexCoord1fADDRESS(s);
                return;
            }
            glTexCoord1fPROCF(s);
        }

        public static void glTexCoord1d(double s) {
            if (glTexCoord1dADDRESS != null) {
                glTexCoord1dADDRESS(s);
                return;
            }
            glTexCoord1dPROCF(s);
        }

        public static void glTexCoord2f(float s, float t) {
            if (glTexCoord2fADDRESS != null) {
                glTexCoord2fADDRESS(s, t);
                return;
            }
            glTexCoord2fPROCF(s, t);
        }

        public static void glTexCoord2d(double s, double t) {
            if (glTexCoord2dADDRESS != null) {
                glTexCoord2dADDRESS(s, t);
                return;
            }
            glTexCoord2dPROCF(s, t);
        }

        public static void glTexCoord3f(float s, float t, float r) {
            if (glTexCoord3fADDRESS != null) {
                glTexCoord3fADDRESS(s, t, r);
                return;
            }
            glTexCoord3fPROCF(s, t, r);
        }

        public static void glTexCoord3d(double s, double t, double r) {
            if (glTexCoord3dADDRESS != null) {
                glTexCoord3dADDRESS(s, t, r);
                return;
            }
            glTexCoord3dPROCF(s, t, r);
        }

        public static void glTexCoord4f(float s, float t, float r, float q) {
            if (glTexCoord4fADDRESS != null) {
                glTexCoord4fADDRESS(s, t, r, q);
                return;
            }
            glTexCoord4fPROCF(s, t, r, q);
        }

        public static void glTexCoord4d(double s, double t, double r, double q) {
            if (glTexCoord4dADDRESS != null) {
                glTexCoord4dADDRESS(s, t, r, q);
                return;
            }
            glTexCoord4dPROCF(s, t, r, q);
        }

        public static void glStencilOp(uint fail, uint zfail, uint zpass) {
            if (glStencilOpADDRESS != null) {
                glStencilOpADDRESS(fail, zfail, zpass);
                return;
            }
            glStencilOpPROCF(fail, zfail, zpass);
        }

        public static void glStencilMask(uint mask) {
            if (glStencilMaskADDRESS != null) {
                glStencilMaskADDRESS(mask);
                return;
            }
            glStencilMaskPROCF(mask);
        }

        public static void glViewport(int x, int y, int width, int height) {
            if (glViewportADDRESS != null) {
                glViewportADDRESS(x, y, width, height);
                return;
            }
            glViewportPROCF(x, y, width, height);
        }

        #endregion
        #region OpenGL X.X init code
        public static bool initGL() {
            System.IntPtr tempPointer;
            bool result = false;
            if ((tempPointer = GL.getProcAddressLibrary("glAccum")) != System.IntPtr.Zero) result |= (glAccumADDRESS = (glAccumPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glAccumPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glAlphaFunc")) != System.IntPtr.Zero) result |= (glAlphaFuncADDRESS = (glAlphaFuncPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glAlphaFuncPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glClearColor")) != System.IntPtr.Zero) result |= (glClearColorADDRESS = (glClearColorPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glClearColorPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glClearAccum")) != System.IntPtr.Zero) result |= (glClearAccumADDRESS = (glClearAccumPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glClearAccumPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glClear")) != System.IntPtr.Zero) result |= (glClearADDRESS = (glClearPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glClearPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCallLists")) != System.IntPtr.Zero) result |= (glCallListsADDRESS = (glCallListsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCallListsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCallList")) != System.IntPtr.Zero) result |= (glCallListADDRESS = (glCallListPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCallListPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glBlendFunc")) != System.IntPtr.Zero) result |= (glBlendFuncADDRESS = (glBlendFuncPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glBlendFuncPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glBitmap")) != System.IntPtr.Zero) result |= (glBitmapADDRESS = (glBitmapPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glBitmapPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glBindTexture")) != System.IntPtr.Zero) result |= (glBindTextureADDRESS = (glBindTexturePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glBindTexturePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPrioritizeTextures")) != System.IntPtr.Zero) result |= (glPrioritizeTexturesADDRESS = (glPrioritizeTexturesPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPrioritizeTexturesPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glAreTexturesResident")) != System.IntPtr.Zero) result |= (glAreTexturesResidentADDRESS = (glAreTexturesResidentPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glAreTexturesResidentPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glBegin")) != System.IntPtr.Zero) result |= (glBeginADDRESS = (glBeginPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glBeginPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEnd")) != System.IntPtr.Zero) result |= (glEndADDRESS = (glEndPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEndPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glArrayElement")) != System.IntPtr.Zero) result |= (glArrayElementADDRESS = (glArrayElementPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glArrayElementPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glClearDepth")) != System.IntPtr.Zero) result |= (glClearDepthADDRESS = (glClearDepthPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glClearDepthPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDeleteLists")) != System.IntPtr.Zero) result |= (glDeleteListsADDRESS = (glDeleteListsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDeleteListsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDeleteTextures")) != System.IntPtr.Zero) result |= (glDeleteTexturesADDRESS = (glDeleteTexturesPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDeleteTexturesPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCullFace")) != System.IntPtr.Zero) result |= (glCullFaceADDRESS = (glCullFacePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCullFacePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCopyTexSubImage2D")) != System.IntPtr.Zero) result |= (glCopyTexSubImage2DADDRESS = (glCopyTexSubImage2DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCopyTexSubImage2DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCopyTexSubImage1D")) != System.IntPtr.Zero) result |= (glCopyTexSubImage1DADDRESS = (glCopyTexSubImage1DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCopyTexSubImage1DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCopyTexImage2D")) != System.IntPtr.Zero) result |= (glCopyTexImage2DADDRESS = (glCopyTexImage2DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCopyTexImage2DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCopyTexImage1D")) != System.IntPtr.Zero) result |= (glCopyTexImage1DADDRESS = (glCopyTexImage1DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCopyTexImage1DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glCopyPixels")) != System.IntPtr.Zero) result |= (glCopyPixelsADDRESS = (glCopyPixelsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glCopyPixelsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColorPointer")) != System.IntPtr.Zero) result |= (glColorPointerADDRESS = (glColorPointerPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColorPointerPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColorMaterial")) != System.IntPtr.Zero) result |= (glColorMaterialADDRESS = (glColorMaterialPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColorMaterialPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColorMask")) != System.IntPtr.Zero) result |= (glColorMaskADDRESS = (glColorMaskPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColorMaskPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor3b")) != System.IntPtr.Zero) result |= (glColor3bADDRESS = (glColor3bPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor3bPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor3f")) != System.IntPtr.Zero) result |= (glColor3fADDRESS = (glColor3fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor3fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor3d")) != System.IntPtr.Zero) result |= (glColor3dADDRESS = (glColor3dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor3dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor3ub")) != System.IntPtr.Zero) result |= (glColor3ubADDRESS = (glColor3ubPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor3ubPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor4b")) != System.IntPtr.Zero) result |= (glColor4bADDRESS = (glColor4bPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor4bPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor4f")) != System.IntPtr.Zero) result |= (glColor4fADDRESS = (glColor4fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor4fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor4d")) != System.IntPtr.Zero) result |= (glColor4dADDRESS = (glColor4dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor4dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glColor4ub")) != System.IntPtr.Zero) result |= (glColor4ubADDRESS = (glColor4ubPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glColor4ubPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glClipPlane")) != System.IntPtr.Zero) result |= (glClipPlaneADDRESS = (glClipPlanePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glClipPlanePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glClearStencil")) != System.IntPtr.Zero) result |= (glClearStencilADDRESS = (glClearStencilPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glClearStencilPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalPoint1")) != System.IntPtr.Zero) result |= (glEvalPoint1ADDRESS = (glEvalPoint1PROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalPoint1PROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalPoint2")) != System.IntPtr.Zero) result |= (glEvalPoint2ADDRESS = (glEvalPoint2PROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalPoint2PROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalMesh1")) != System.IntPtr.Zero) result |= (glEvalMesh1ADDRESS = (glEvalMesh1PROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalMesh1PROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalMesh2")) != System.IntPtr.Zero) result |= (glEvalMesh2ADDRESS = (glEvalMesh2PROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalMesh2PROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalCoord1f")) != System.IntPtr.Zero) result |= (glEvalCoord1fADDRESS = (glEvalCoord1fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalCoord1fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalCoord1d")) != System.IntPtr.Zero) result |= (glEvalCoord1dADDRESS = (glEvalCoord1dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalCoord1dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalCoord2f")) != System.IntPtr.Zero) result |= (glEvalCoord2fADDRESS = (glEvalCoord2fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalCoord2fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEvalCoord2d")) != System.IntPtr.Zero) result |= (glEvalCoord2dADDRESS = (glEvalCoord2dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEvalCoord2dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEnableClientState")) != System.IntPtr.Zero) result |= (glEnableClientStateADDRESS = (glEnableClientStatePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEnableClientStatePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDisableClientState")) != System.IntPtr.Zero) result |= (glDisableClientStateADDRESS = (glDisableClientStatePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDisableClientStatePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEnable")) != System.IntPtr.Zero) result |= (glEnableADDRESS = (glEnablePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEnablePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDisable")) != System.IntPtr.Zero) result |= (glDisableADDRESS = (glDisablePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDisablePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEdgeFlagPointer")) != System.IntPtr.Zero) result |= (glEdgeFlagPointerADDRESS = (glEdgeFlagPointerPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEdgeFlagPointerPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEdgeFlag")) != System.IntPtr.Zero) result |= (glEdgeFlagADDRESS = (glEdgeFlagPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEdgeFlagPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDrawPixels")) != System.IntPtr.Zero) result |= (glDrawPixelsADDRESS = (glDrawPixelsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDrawPixelsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDrawElements")) != System.IntPtr.Zero) result |= (glDrawElementsADDRESS = (glDrawElementsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDrawElementsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDrawBuffer")) != System.IntPtr.Zero) result |= (glDrawBufferADDRESS = (glDrawBufferPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDrawBufferPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDrawArrays")) != System.IntPtr.Zero) result |= (glDrawArraysADDRESS = (glDrawArraysPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDrawArraysPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDepthRange")) != System.IntPtr.Zero) result |= (glDepthRangeADDRESS = (glDepthRangePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDepthRangePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDepthMask")) != System.IntPtr.Zero) result |= (glDepthMaskADDRESS = (glDepthMaskPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDepthMaskPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glDepthFunc")) != System.IntPtr.Zero) result |= (glDepthFuncADDRESS = (glDepthFuncPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glDepthFuncPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFeedbackBuffer")) != System.IntPtr.Zero) result |= (glFeedbackBufferADDRESS = (glFeedbackBufferPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFeedbackBufferPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetPixelMapfv")) != System.IntPtr.Zero) result |= (glGetPixelMapfvADDRESS = (glGetPixelMapfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetPixelMapfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetPixelMapuiv")) != System.IntPtr.Zero) result |= (glGetPixelMapuivADDRESS = (glGetPixelMapuivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetPixelMapuivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetPixelMapusv")) != System.IntPtr.Zero) result |= (glGetPixelMapusvADDRESS = (glGetPixelMapusvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetPixelMapusvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetMaterialfv")) != System.IntPtr.Zero) result |= (glGetMaterialfvADDRESS = (glGetMaterialfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetMaterialfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetMaterialiv")) != System.IntPtr.Zero) result |= (glGetMaterialivADDRESS = (glGetMaterialivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetMaterialivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetMapfv")) != System.IntPtr.Zero) result |= (glGetMapfvADDRESS = (glGetMapfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetMapfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetMapdv")) != System.IntPtr.Zero) result |= (glGetMapdvADDRESS = (glGetMapdvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetMapdvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetMapiv")) != System.IntPtr.Zero) result |= (glGetMapivADDRESS = (glGetMapivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetMapivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetLightfv")) != System.IntPtr.Zero) result |= (glGetLightfvADDRESS = (glGetLightfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetLightfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetLightiv")) != System.IntPtr.Zero) result |= (glGetLightivADDRESS = (glGetLightivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetLightivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetError")) != System.IntPtr.Zero) result |= (glGetErrorADDRESS = (glGetErrorPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetErrorPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetClipPlane")) != System.IntPtr.Zero) result |= (glGetClipPlaneADDRESS = (glGetClipPlanePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetClipPlanePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetBooleanv")) != System.IntPtr.Zero) result |= (glGetBooleanvADDRESS = (glGetBooleanvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetBooleanvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetDoublev")) != System.IntPtr.Zero) result |= (glGetDoublevADDRESS = (glGetDoublevPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetDoublevPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetFloatv")) != System.IntPtr.Zero) result |= (glGetFloatvADDRESS = (glGetFloatvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetFloatvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetIntegerv")) != System.IntPtr.Zero) result |= (glGetIntegervADDRESS = (glGetIntegervPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetIntegervPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGenTextures")) != System.IntPtr.Zero) result |= (glGenTexturesADDRESS = (glGenTexturesPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGenTexturesPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGenLists")) != System.IntPtr.Zero) result |= (glGenListsADDRESS = (glGenListsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGenListsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFrustum")) != System.IntPtr.Zero) result |= (glFrustumADDRESS = (glFrustumPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFrustumPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFrontFace")) != System.IntPtr.Zero) result |= (glFrontFaceADDRESS = (glFrontFacePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFrontFacePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFogf")) != System.IntPtr.Zero) result |= (glFogfADDRESS = (glFogfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFogfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFogi")) != System.IntPtr.Zero) result |= (glFogiADDRESS = (glFogiPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFogiPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFogfv")) != System.IntPtr.Zero) result |= (glFogfvADDRESS = (glFogfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFogfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFogiv")) != System.IntPtr.Zero) result |= (glFogivADDRESS = (glFogivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFogivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFlush")) != System.IntPtr.Zero) result |= (glFlushADDRESS = (glFlushPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFlushPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glFinish")) != System.IntPtr.Zero) result |= (glFinishADDRESS = (glFinishPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glFinishPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetPointerv")) != System.IntPtr.Zero) result |= (glGetPointervADDRESS = (glGetPointervPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetPointervPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glIsEnabled")) != System.IntPtr.Zero) result |= (glIsEnabledADDRESS = (glIsEnabledPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glIsEnabledPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glInterleavedArrays")) != System.IntPtr.Zero) result |= (glInterleavedArraysADDRESS = (glInterleavedArraysPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glInterleavedArraysPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glInitNames")) != System.IntPtr.Zero) result |= (glInitNamesADDRESS = (glInitNamesPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glInitNamesPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glHint")) != System.IntPtr.Zero) result |= (glHintADDRESS = (glHintPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glHintPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexParameterfv")) != System.IntPtr.Zero) result |= (glGetTexParameterfvADDRESS = (glGetTexParameterfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexParameterfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexParameteriv")) != System.IntPtr.Zero) result |= (glGetTexParameterivADDRESS = (glGetTexParameterivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexParameterivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexLevelParameterfv")) != System.IntPtr.Zero) result |= (glGetTexLevelParameterfvADDRESS = (glGetTexLevelParameterfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexLevelParameterfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexLevelParameteriv")) != System.IntPtr.Zero) result |= (glGetTexLevelParameterivADDRESS = (glGetTexLevelParameterivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexLevelParameterivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexImage")) != System.IntPtr.Zero) result |= (glGetTexImageADDRESS = (glGetTexImagePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexImagePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexGeniv")) != System.IntPtr.Zero) result |= (glGetTexGenivADDRESS = (glGetTexGenivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexGenivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexGenfv")) != System.IntPtr.Zero) result |= (glGetTexGenfvADDRESS = (glGetTexGenfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexGenfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexGendv")) != System.IntPtr.Zero) result |= (glGetTexGendvADDRESS = (glGetTexGendvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexGendvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexEnviv")) != System.IntPtr.Zero) result |= (glGetTexEnvivADDRESS = (glGetTexEnvivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexEnvivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetTexEnvfv")) != System.IntPtr.Zero) result |= (glGetTexEnvfvADDRESS = (glGetTexEnvfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetTexEnvfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetString")) != System.IntPtr.Zero) result |= (glGetStringADDRESS = (glGetStringPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetStringPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glGetPolygonStipple")) != System.IntPtr.Zero) result |= (glGetPolygonStippleADDRESS = (glGetPolygonStipplePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glGetPolygonStipplePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glIsList")) != System.IntPtr.Zero) result |= (glIsListADDRESS = (glIsListPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glIsListPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMaterialf")) != System.IntPtr.Zero) result |= (glMaterialfADDRESS = (glMaterialfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMaterialfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMateriali")) != System.IntPtr.Zero) result |= (glMaterialiADDRESS = (glMaterialiPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMaterialiPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMaterialfv")) != System.IntPtr.Zero) result |= (glMaterialfvADDRESS = (glMaterialfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMaterialfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMaterialiv")) != System.IntPtr.Zero) result |= (glMaterialivADDRESS = (glMaterialivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMaterialivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMapGrid1f")) != System.IntPtr.Zero) result |= (glMapGrid1fADDRESS = (glMapGrid1fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMapGrid1fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMapGrid1d")) != System.IntPtr.Zero) result |= (glMapGrid1dADDRESS = (glMapGrid1dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMapGrid1dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMapGrid2f")) != System.IntPtr.Zero) result |= (glMapGrid2fADDRESS = (glMapGrid2fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMapGrid2fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMapGrid2d")) != System.IntPtr.Zero) result |= (glMapGrid2dADDRESS = (glMapGrid2dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMapGrid2dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMap2f")) != System.IntPtr.Zero) result |= (glMap2fADDRESS = (glMap2fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMap2fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMap2d")) != System.IntPtr.Zero) result |= (glMap2dADDRESS = (glMap2dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMap2dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMap1f")) != System.IntPtr.Zero) result |= (glMap1fADDRESS = (glMap1fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMap1fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMap1d")) != System.IntPtr.Zero) result |= (glMap1dADDRESS = (glMap1dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMap1dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLogicOp")) != System.IntPtr.Zero) result |= (glLogicOpADDRESS = (glLogicOpPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLogicOpPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLoadName")) != System.IntPtr.Zero) result |= (glLoadNameADDRESS = (glLoadNamePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLoadNamePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLoadMatrixf")) != System.IntPtr.Zero) result |= (glLoadMatrixfADDRESS = (glLoadMatrixfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLoadMatrixfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLoadMatrixd")) != System.IntPtr.Zero) result |= (glLoadMatrixdADDRESS = (glLoadMatrixdPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLoadMatrixdPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLoadIdentity")) != System.IntPtr.Zero) result |= (glLoadIdentityADDRESS = (glLoadIdentityPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLoadIdentityPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glListBase")) != System.IntPtr.Zero) result |= (glListBaseADDRESS = (glListBasePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glListBasePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLineWidth")) != System.IntPtr.Zero) result |= (glLineWidthADDRESS = (glLineWidthPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLineWidthPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLineStipple")) != System.IntPtr.Zero) result |= (glLineStippleADDRESS = (glLineStipplePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLineStipplePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightModelf")) != System.IntPtr.Zero) result |= (glLightModelfADDRESS = (glLightModelfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightModelfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightModeli")) != System.IntPtr.Zero) result |= (glLightModeliADDRESS = (glLightModeliPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightModeliPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightModelfv")) != System.IntPtr.Zero) result |= (glLightModelfvADDRESS = (glLightModelfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightModelfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightModeliv")) != System.IntPtr.Zero) result |= (glLightModelivADDRESS = (glLightModelivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightModelivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightf")) != System.IntPtr.Zero) result |= (glLightfADDRESS = (glLightfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLighti")) != System.IntPtr.Zero) result |= (glLightiADDRESS = (glLightiPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightiPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightfv")) != System.IntPtr.Zero) result |= (glLightfvADDRESS = (glLightfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glLightiv")) != System.IntPtr.Zero) result |= (glLightivADDRESS = (glLightivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glLightivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glIsTexture")) != System.IntPtr.Zero) result |= (glIsTextureADDRESS = (glIsTexturePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glIsTexturePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMatrixMode")) != System.IntPtr.Zero) result |= (glMatrixModeADDRESS = (glMatrixModePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMatrixModePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPolygonStipple")) != System.IntPtr.Zero) result |= (glPolygonStippleADDRESS = (glPolygonStipplePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPolygonStipplePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPolygonOffset")) != System.IntPtr.Zero) result |= (glPolygonOffsetADDRESS = (glPolygonOffsetPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPolygonOffsetPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPolygonMode")) != System.IntPtr.Zero) result |= (glPolygonModeADDRESS = (glPolygonModePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPolygonModePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPointSize")) != System.IntPtr.Zero) result |= (glPointSizeADDRESS = (glPointSizePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPointSizePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelZoom")) != System.IntPtr.Zero) result |= (glPixelZoomADDRESS = (glPixelZoomPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelZoomPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelTransferf")) != System.IntPtr.Zero) result |= (glPixelTransferfADDRESS = (glPixelTransferfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelTransferfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelTransferi")) != System.IntPtr.Zero) result |= (glPixelTransferiADDRESS = (glPixelTransferiPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelTransferiPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelStoref")) != System.IntPtr.Zero) result |= (glPixelStorefADDRESS = (glPixelStorefPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelStorefPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelStorei")) != System.IntPtr.Zero) result |= (glPixelStoreiADDRESS = (glPixelStoreiPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelStoreiPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelMapfv")) != System.IntPtr.Zero) result |= (glPixelMapfvADDRESS = (glPixelMapfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelMapfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelMapuiv")) != System.IntPtr.Zero) result |= (glPixelMapuivADDRESS = (glPixelMapuivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelMapuivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPixelMapusv")) != System.IntPtr.Zero) result |= (glPixelMapusvADDRESS = (glPixelMapusvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPixelMapusvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPassThrough")) != System.IntPtr.Zero) result |= (glPassThroughADDRESS = (glPassThroughPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPassThroughPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glOrtho")) != System.IntPtr.Zero) result |= (glOrthoADDRESS = (glOrthoPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glOrthoPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glNormalPointer")) != System.IntPtr.Zero) result |= (glNormalPointerADDRESS = (glNormalPointerPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glNormalPointerPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glNormal3b")) != System.IntPtr.Zero) result |= (glNormal3bADDRESS = (glNormal3bPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glNormal3bPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glNormal3f")) != System.IntPtr.Zero) result |= (glNormal3fADDRESS = (glNormal3fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glNormal3fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glNormal3d")) != System.IntPtr.Zero) result |= (glNormal3dADDRESS = (glNormal3dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glNormal3dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glNormal3i")) != System.IntPtr.Zero) result |= (glNormal3iADDRESS = (glNormal3iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glNormal3iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glNewList")) != System.IntPtr.Zero) result |= (glNewListADDRESS = (glNewListPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glNewListPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glEndList")) != System.IntPtr.Zero) result |= (glEndListADDRESS = (glEndListPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glEndListPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMultMatrixf")) != System.IntPtr.Zero) result |= (glMultMatrixfADDRESS = (glMultMatrixfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMultMatrixfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glMultMatrixd")) != System.IntPtr.Zero) result |= (glMultMatrixdADDRESS = (glMultMatrixdPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glMultMatrixdPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glShadeModel")) != System.IntPtr.Zero) result |= (glShadeModelADDRESS = (glShadeModelPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glShadeModelPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glSelectBuffer")) != System.IntPtr.Zero) result |= (glSelectBufferADDRESS = (glSelectBufferPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glSelectBufferPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glScissor")) != System.IntPtr.Zero) result |= (glScissorADDRESS = (glScissorPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glScissorPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glScalef")) != System.IntPtr.Zero) result |= (glScalefADDRESS = (glScalefPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glScalefPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glScaled")) != System.IntPtr.Zero) result |= (glScaledADDRESS = (glScaledPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glScaledPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRotatef")) != System.IntPtr.Zero) result |= (glRotatefADDRESS = (glRotatefPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRotatefPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRenderMode")) != System.IntPtr.Zero) result |= (glRenderModeADDRESS = (glRenderModePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRenderModePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRectf")) != System.IntPtr.Zero) result |= (glRectfADDRESS = (glRectfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRectfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRectd")) != System.IntPtr.Zero) result |= (glRectdADDRESS = (glRectdPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRectdPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRecti")) != System.IntPtr.Zero) result |= (glRectiADDRESS = (glRectiPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRectiPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glReadPixels")) != System.IntPtr.Zero) result |= (glReadPixelsADDRESS = (glReadPixelsPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glReadPixelsPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glReadBuffer")) != System.IntPtr.Zero) result |= (glReadBufferADDRESS = (glReadBufferPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glReadBufferPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos2f")) != System.IntPtr.Zero) result |= (glRasterPos2fADDRESS = (glRasterPos2fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos2fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos2d")) != System.IntPtr.Zero) result |= (glRasterPos2dADDRESS = (glRasterPos2dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos2dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos2i")) != System.IntPtr.Zero) result |= (glRasterPos2iADDRESS = (glRasterPos2iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos2iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos3f")) != System.IntPtr.Zero) result |= (glRasterPos3fADDRESS = (glRasterPos3fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos3fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos3d")) != System.IntPtr.Zero) result |= (glRasterPos3dADDRESS = (glRasterPos3dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos3dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos3i")) != System.IntPtr.Zero) result |= (glRasterPos3iADDRESS = (glRasterPos3iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos3iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos4f")) != System.IntPtr.Zero) result |= (glRasterPos4fADDRESS = (glRasterPos4fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos4fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos4d")) != System.IntPtr.Zero) result |= (glRasterPos4dADDRESS = (glRasterPos4dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos4dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glRasterPos4i")) != System.IntPtr.Zero) result |= (glRasterPos4iADDRESS = (glRasterPos4iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glRasterPos4iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPushName")) != System.IntPtr.Zero) result |= (glPushNameADDRESS = (glPushNamePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPushNamePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPopName")) != System.IntPtr.Zero) result |= (glPopNameADDRESS = (glPopNamePROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPopNamePROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPushMatrix")) != System.IntPtr.Zero) result |= (glPushMatrixADDRESS = (glPushMatrixPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPushMatrixPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPopMatrix")) != System.IntPtr.Zero) result |= (glPopMatrixADDRESS = (glPopMatrixPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPopMatrixPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPushClientAttrib")) != System.IntPtr.Zero) result |= (glPushClientAttribADDRESS = (glPushClientAttribPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPushClientAttribPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPopClientAttrib")) != System.IntPtr.Zero) result |= (glPopClientAttribADDRESS = (glPopClientAttribPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPopClientAttribPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPushAttrib")) != System.IntPtr.Zero) result |= (glPushAttribADDRESS = (glPushAttribPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPushAttribPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glPopAttrib")) != System.IntPtr.Zero) result |= (glPopAttribADDRESS = (glPopAttribPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glPopAttribPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glStencilFunc")) != System.IntPtr.Zero) result |= (glStencilFuncADDRESS = (glStencilFuncPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glStencilFuncPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertexPointer")) != System.IntPtr.Zero) result |= (glVertexPointerADDRESS = (glVertexPointerPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertexPointerPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex2f")) != System.IntPtr.Zero) result |= (glVertex2fADDRESS = (glVertex2fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex2fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex2d")) != System.IntPtr.Zero) result |= (glVertex2dADDRESS = (glVertex2dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex2dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex2i")) != System.IntPtr.Zero) result |= (glVertex2iADDRESS = (glVertex2iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex2iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex3f")) != System.IntPtr.Zero) result |= (glVertex3fADDRESS = (glVertex3fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex3fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex3d")) != System.IntPtr.Zero) result |= (glVertex3dADDRESS = (glVertex3dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex3dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex3i")) != System.IntPtr.Zero) result |= (glVertex3iADDRESS = (glVertex3iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex3iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex4f")) != System.IntPtr.Zero) result |= (glVertex4fADDRESS = (glVertex4fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex4fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex4d")) != System.IntPtr.Zero) result |= (glVertex4dADDRESS = (glVertex4dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex4dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glVertex4i")) != System.IntPtr.Zero) result |= (glVertex4iADDRESS = (glVertex4iPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glVertex4iPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTranslatef")) != System.IntPtr.Zero) result |= (glTranslatefADDRESS = (glTranslatefPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTranslatefPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTranslated")) != System.IntPtr.Zero) result |= (glTranslatedADDRESS = (glTranslatedPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTranslatedPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexImage1D")) != System.IntPtr.Zero) result |= (glTexImage1DADDRESS = (glTexImage1DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexImage1DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexImage2D")) != System.IntPtr.Zero) result |= (glTexImage2DADDRESS = (glTexImage2DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexImage2DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexSubImage1D")) != System.IntPtr.Zero) result |= (glTexSubImage1DADDRESS = (glTexSubImage1DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexSubImage1DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexSubImage2D")) != System.IntPtr.Zero) result |= (glTexSubImage2DADDRESS = (glTexSubImage2DPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexSubImage2DPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexParameterf")) != System.IntPtr.Zero) result |= (glTexParameterfADDRESS = (glTexParameterfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexParameterfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexParameteri")) != System.IntPtr.Zero) result |= (glTexParameteriADDRESS = (glTexParameteriPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexParameteriPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexParameterfv")) != System.IntPtr.Zero) result |= (glTexParameterfvADDRESS = (glTexParameterfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexParameterfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexParameteriv")) != System.IntPtr.Zero) result |= (glTexParameterivADDRESS = (glTexParameterivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexParameterivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexGenf")) != System.IntPtr.Zero) result |= (glTexGenfADDRESS = (glTexGenfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexGenfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexGend")) != System.IntPtr.Zero) result |= (glTexGendADDRESS = (glTexGendPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexGendPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexGenfv")) != System.IntPtr.Zero) result |= (glTexGenfvADDRESS = (glTexGenfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexGenfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexGendv")) != System.IntPtr.Zero) result |= (glTexGendvADDRESS = (glTexGendvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexGendvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexGeni")) != System.IntPtr.Zero) result |= (glTexGeniADDRESS = (glTexGeniPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexGeniPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexGeniv")) != System.IntPtr.Zero) result |= (glTexGenivADDRESS = (glTexGenivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexGenivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexEnvf")) != System.IntPtr.Zero) result |= (glTexEnvfADDRESS = (glTexEnvfPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexEnvfPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexEnvi")) != System.IntPtr.Zero) result |= (glTexEnviADDRESS = (glTexEnviPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexEnviPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexEnvfv")) != System.IntPtr.Zero) result |= (glTexEnvfvADDRESS = (glTexEnvfvPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexEnvfvPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexEnviv")) != System.IntPtr.Zero) result |= (glTexEnvivADDRESS = (glTexEnvivPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexEnvivPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoordPointer")) != System.IntPtr.Zero) result |= (glTexCoordPointerADDRESS = (glTexCoordPointerPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoordPointerPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord1f")) != System.IntPtr.Zero) result |= (glTexCoord1fADDRESS = (glTexCoord1fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord1fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord1d")) != System.IntPtr.Zero) result |= (glTexCoord1dADDRESS = (glTexCoord1dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord1dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord2f")) != System.IntPtr.Zero) result |= (glTexCoord2fADDRESS = (glTexCoord2fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord2fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord2d")) != System.IntPtr.Zero) result |= (glTexCoord2dADDRESS = (glTexCoord2dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord2dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord3f")) != System.IntPtr.Zero) result |= (glTexCoord3fADDRESS = (glTexCoord3fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord3fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord3d")) != System.IntPtr.Zero) result |= (glTexCoord3dADDRESS = (glTexCoord3dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord3dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord4f")) != System.IntPtr.Zero) result |= (glTexCoord4fADDRESS = (glTexCoord4fPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord4fPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glTexCoord4d")) != System.IntPtr.Zero) result |= (glTexCoord4dADDRESS = (glTexCoord4dPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glTexCoord4dPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glStencilOp")) != System.IntPtr.Zero) result |= (glStencilOpADDRESS = (glStencilOpPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glStencilOpPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glStencilMask")) != System.IntPtr.Zero) result |= (glStencilMaskADDRESS = (glStencilMaskPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glStencilMaskPROC))) != null;
            if ((tempPointer = GL.getProcAddressLibrary("glViewport")) != System.IntPtr.Zero) result |= (glViewportADDRESS = (glViewportPROC)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(tempPointer, typeof(glViewportPROC))) != null;
            return result;
        }

        #endregion
    }
}
