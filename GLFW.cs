// Ref: https://www.glfw.org/docs/3.3/glfw3_8h_source.html

using System;
using System.Runtime.InteropServices;

// Ver: 3.3.7
internal static class GLFW
{
    // DLL: https://www.glfw.org/download.html

    internal const string libraryPath = @$"glfw3.dll";

    // ************************************** //
    // API Tokens                             //
    // ************************************** //

    public const int GLFW_VERSION_MAJOR = 3;
    public const int GLFW_VERSION_MINOR = 3;
    public const int GLFW_VERSION_REVISION = 7;
    public const int GLFW_TRUE = 1;
    public const int GLFW_FALSE = 0;

    public const int GLFW_RELEASE = 0;
    public const int GLFW_PRESS = 1;
    public const int GLFW_REPEAT = 2;
    public const int GLFW_HAT_CENTERED = 0;
    public const int GLFW_HAT_UP = 1;
    public const int GLFW_HAT_RIGHT = 2;
    public const int GLFW_HAT_DOWN = 4;
    public const int GLFW_HAT_LEFT = 8;

    public static int GLFW_HAT_RIGHT_UP => (GLFW_HAT_RIGHT | GLFW_HAT_UP);
    public static int GLFW_HAT_RIGHT_DOWN => (GLFW_HAT_RIGHT | GLFW_HAT_DOWN);
    public static int GLFW_HAT_LEFT_UP => (GLFW_HAT_LEFT | GLFW_HAT_UP);
    public static int GLFW_HAT_LEFT_DOWN => (GLFW_HAT_LEFT | GLFW_HAT_DOWN);

    public const int GLFW_KEY_UNKNOWN = -1;

    public const int GLFW_KEY_SPACE = 32;
    public const int GLFW_KEY_APOSTROPHE = 39;
    public const int GLFW_KEY_COMMA = 44;
    public const int GLFW_KEY_MINUS = 45;
    public const int GLFW_KEY_PERIOD = 46;
    public const int GLFW_KEY_SLASH = 47;
    public const int GLFW_KEY_0 = 48;
    public const int GLFW_KEY_1 = 49;
    public const int GLFW_KEY_2 = 50;
    public const int GLFW_KEY_3 = 51;
    public const int GLFW_KEY_4 = 52;
    public const int GLFW_KEY_5 = 53;
    public const int GLFW_KEY_6 = 54;
    public const int GLFW_KEY_7 = 55;
    public const int GLFW_KEY_8 = 56;
    public const int GLFW_KEY_9 = 57;
    public const int GLFW_KEY_SEMICOLON = 59;
    public const int GLFW_KEY_EQUAL = 61;
    public const int GLFW_KEY_A = 65;
    public const int GLFW_KEY_B = 66;
    public const int GLFW_KEY_C = 67;
    public const int GLFW_KEY_D = 68;
    public const int GLFW_KEY_E = 69;
    public const int GLFW_KEY_F = 70;
    public const int GLFW_KEY_G = 71;
    public const int GLFW_KEY_H = 72;
    public const int GLFW_KEY_I = 73;
    public const int GLFW_KEY_J = 74;
    public const int GLFW_KEY_K = 75;
    public const int GLFW_KEY_L = 76;
    public const int GLFW_KEY_M = 77;
    public const int GLFW_KEY_N = 78;
    public const int GLFW_KEY_O = 79;
    public const int GLFW_KEY_P = 80;
    public const int GLFW_KEY_Q = 81;
    public const int GLFW_KEY_R = 82;
    public const int GLFW_KEY_S = 83;
    public const int GLFW_KEY_T = 84;
    public const int GLFW_KEY_U = 85;
    public const int GLFW_KEY_V = 86;
    public const int GLFW_KEY_W = 87;
    public const int GLFW_KEY_X = 88;
    public const int GLFW_KEY_Y = 89;
    public const int GLFW_KEY_Z = 90;
    public const int GLFW_KEY_LEFT_BRACKET = 91;
    public const int GLFW_KEY_BACKSLASH = 92;
    public const int GLFW_KEY_RIGHT_BRACKET = 93;
    public const int GLFW_KEY_GRAVE_ACCENT = 96;
    public const int GLFW_KEY_WORLD_1 = 161;
    public const int GLFW_KEY_WORLD_2 = 162;

    public const int GLFW_KEY_ESCAPE = 256;
    public const int GLFW_KEY_ENTER = 257;
    public const int GLFW_KEY_TAB = 258;
    public const int GLFW_KEY_BACKSPACE = 259;
    public const int GLFW_KEY_INSERT = 260;
    public const int GLFW_KEY_DELETE = 261;
    public const int GLFW_KEY_RIGHT = 262;
    public const int GLFW_KEY_LEFT = 263;
    public const int GLFW_KEY_DOWN = 264;
    public const int GLFW_KEY_UP = 265;
    public const int GLFW_KEY_PAGE_UP = 266;
    public const int GLFW_KEY_PAGE_DOWN = 267;
    public const int GLFW_KEY_HOME = 268;
    public const int GLFW_KEY_END = 269;
    public const int GLFW_KEY_CAPS_LOCK = 280;
    public const int GLFW_KEY_SCROLL_LOCK = 281;
    public const int GLFW_KEY_NUM_LOCK = 282;
    public const int GLFW_KEY_PRINT_SCREEN = 283;
    public const int GLFW_KEY_PAUSE = 284;
    public const int GLFW_KEY_F1 = 290;
    public const int GLFW_KEY_F2 = 291;
    public const int GLFW_KEY_F3 = 292;
    public const int GLFW_KEY_F4 = 293;
    public const int GLFW_KEY_F5 = 294;
    public const int GLFW_KEY_F6 = 295;
    public const int GLFW_KEY_F7 = 296;
    public const int GLFW_KEY_F8 = 297;
    public const int GLFW_KEY_F9 = 298;
    public const int GLFW_KEY_F10 = 299;
    public const int GLFW_KEY_F11 = 300;
    public const int GLFW_KEY_F12 = 301;
    public const int GLFW_KEY_F13 = 302;
    public const int GLFW_KEY_F14 = 303;
    public const int GLFW_KEY_F15 = 304;
    public const int GLFW_KEY_F16 = 305;
    public const int GLFW_KEY_F17 = 306;
    public const int GLFW_KEY_F18 = 307;
    public const int GLFW_KEY_F19 = 308;
    public const int GLFW_KEY_F20 = 309;
    public const int GLFW_KEY_F21 = 310;
    public const int GLFW_KEY_F22 = 311;
    public const int GLFW_KEY_F23 = 312;
    public const int GLFW_KEY_F24 = 313;
    public const int GLFW_KEY_F25 = 314;
    public const int GLFW_KEY_KP_0 = 320;
    public const int GLFW_KEY_KP_1 = 321;
    public const int GLFW_KEY_KP_2 = 322;
    public const int GLFW_KEY_KP_3 = 323;
    public const int GLFW_KEY_KP_4 = 324;
    public const int GLFW_KEY_KP_5 = 325;
    public const int GLFW_KEY_KP_6 = 326;
    public const int GLFW_KEY_KP_7 = 327;
    public const int GLFW_KEY_KP_8 = 328;
    public const int GLFW_KEY_KP_9 = 329;
    public const int GLFW_KEY_KP_DECIMAL = 330;
    public const int GLFW_KEY_KP_DIVIDE = 331;
    public const int GLFW_KEY_KP_MULTIPLY = 332;
    public const int GLFW_KEY_KP_SUBTRACT = 333;
    public const int GLFW_KEY_KP_ADD = 334;
    public const int GLFW_KEY_KP_ENTER = 335;
    public const int GLFW_KEY_KP_EQUAL = 336;
    public const int GLFW_KEY_LEFT_SHIFT = 340;
    public const int GLFW_KEY_LEFT_CONTROL = 341;
    public const int GLFW_KEY_LEFT_ALT = 342;
    public const int GLFW_KEY_LEFT_SUPER = 343;
    public const int GLFW_KEY_RIGHT_SHIFT = 344;
    public const int GLFW_KEY_RIGHT_CONTROL = 345;
    public const int GLFW_KEY_RIGHT_ALT = 346;
    public const int GLFW_KEY_RIGHT_SUPER = 347;
    public const int GLFW_KEY_MENU = 348;

    public const int GLFW_KEY_LAST = GLFW_KEY_MENU;

    public const int GLFW_MOD_SHIFT = 0x0001;
    public const int GLFW_MOD_CONTROL = 0x0002;
    public const int GLFW_MOD_ALT = 0x0004;
    public const int GLFW_MOD_SUPER = 0x0008;
    public const int GLFW_MOD_CAPS_LOCK = 0x0010;
    public const int GLFW_MOD_NUM_LOCK = 0x0020;

    public const int GLFW_MOUSE_BUTTON_1 = 0;
    public const int GLFW_MOUSE_BUTTON_2 = 1;
    public const int GLFW_MOUSE_BUTTON_3 = 2;
    public const int GLFW_MOUSE_BUTTON_4 = 3;
    public const int GLFW_MOUSE_BUTTON_5 = 4;
    public const int GLFW_MOUSE_BUTTON_6 = 5;
    public const int GLFW_MOUSE_BUTTON_7 = 6;
    public const int GLFW_MOUSE_BUTTON_8 = 7;
    public const int GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
    public const int GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
    public const int GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
    public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
    public const int GLFW_JOYSTICK_1 = 0;
    public const int GLFW_JOYSTICK_2 = 1;
    public const int GLFW_JOYSTICK_3 = 2;
    public const int GLFW_JOYSTICK_4 = 3;
    public const int GLFW_JOYSTICK_5 = 4;
    public const int GLFW_JOYSTICK_6 = 5;
    public const int GLFW_JOYSTICK_7 = 6;
    public const int GLFW_JOYSTICK_8 = 7;
    public const int GLFW_JOYSTICK_9 = 8;
    public const int GLFW_JOYSTICK_10 = 9;
    public const int GLFW_JOYSTICK_11 = 10;
    public const int GLFW_JOYSTICK_12 = 11;
    public const int GLFW_JOYSTICK_13 = 12;
    public const int GLFW_JOYSTICK_14 = 13;
    public const int GLFW_JOYSTICK_15 = 14;
    public const int GLFW_JOYSTICK_16 = 15;
    public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
    public const int GLFW_GAMEPAD_BUTTON_A = 0;
    public const int GLFW_GAMEPAD_BUTTON_B = 1;
    public const int GLFW_GAMEPAD_BUTTON_X = 2;
    public const int GLFW_GAMEPAD_BUTTON_Y = 3;
    public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 4;
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
    public const int GLFW_GAMEPAD_BUTTON_BACK = 6;
    public const int GLFW_GAMEPAD_BUTTON_START = 7;
    public const int GLFW_GAMEPAD_BUTTON_GUIDE = 8;
    public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 9;
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 10;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 11;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 12;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 13;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 14;
    public const int GLFW_GAMEPAD_BUTTON_LAST = GLFW_GAMEPAD_BUTTON_DPAD_LEFT;

    public const int GLFW_GAMEPAD_BUTTON_CROSS = GLFW_GAMEPAD_BUTTON_A;
    public const int GLFW_GAMEPAD_BUTTON_CIRCLE = GLFW_GAMEPAD_BUTTON_B;
    public const int GLFW_GAMEPAD_BUTTON_SQUARE = GLFW_GAMEPAD_BUTTON_X;
    public const int GLFW_GAMEPAD_BUTTON_TRIANGLE = GLFW_GAMEPAD_BUTTON_Y;
    public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0;
    public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 1;
    public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 2;
    public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 3;
    public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 4;
    public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
    public const int GLFW_GAMEPAD_AXIS_LAST = GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
    public const int GLFW_NO_ERROR = 0;
    public const int GLFW_NOT_INITIALIZED = 0x00010001;
    public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
    public const int GLFW_INVALID_ENUM = 0x00010003;
    public const int GLFW_INVALID_VALUE = 0x00010004;
    public const int GLFW_OUT_OF_MEMORY = 0x00010005;
    public const int GLFW_API_UNAVAILABLE = 0x00010006;
    public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
    public const int GLFW_PLATFORM_ERROR = 0x00010008;
    public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
    public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
    public const int GLFW_FOCUSED = 0x00020001;
    public const int GLFW_ICONIFIED = 0x00020002;
    public const int GLFW_RESIZABLE = 0x00020003;
    public const int GLFW_VISIBLE = 0x00020004;
    public const int GLFW_DECORATED = 0x00020005;
    public const int GLFW_AUTO_ICONIFY = 0x00020006;
    public const int GLFW_FLOATING = 0x00020007;
    public const int GLFW_MAXIMIZED = 0x00020008;
    public const int GLFW_CENTER_CURSOR = 0x00020009;
    public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
    public const int GLFW_HOVERED = 0x0002000B;
    public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;

    public const int GLFW_RED_BITS = 0x00021001;
    public const int GLFW_GREEN_BITS = 0x00021002;
    public const int GLFW_BLUE_BITS = 0x00021003;
    public const int GLFW_ALPHA_BITS = 0x00021004;
    public const int GLFW_DEPTH_BITS = 0x00021005;
    public const int GLFW_STENCIL_BITS = 0x00021006;
    public const int GLFW_ACCUM_RED_BITS = 0x00021007;
    public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
    public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
    public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
    public const int GLFW_AUX_BUFFERS = 0x0002100B;
    public const int GLFW_STEREO = 0x0002100C;
    public const int GLFW_SAMPLES = 0x0002100D;
    public const int GLFW_SRGB_CAPABLE = 0x0002100E;
    public const int GLFW_REFRESH_RATE = 0x0002100F;
    public const int GLFW_DOUBLEBUFFER = 0x00021010;

    public const int GLFW_CLIENT_API = 0x00022001;
    public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
    public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
    public const int GLFW_CONTEXT_REVISION = 0x00022004;
    public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
    public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
    public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007;
    public const int GLFW_OPENGL_PROFILE = 0x00022008;
    public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
    public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
    public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
    public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;
    public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
    public const int GLFW_COCOA_FRAME_NAME = 0x00023002;
    public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
    public const int GLFW_X11_CLASS_NAME = 0x00024001;
    public const int GLFW_X11_INSTANCE_NAME = 0x00024002;
    public const int GLFW_NO_API = 0;
    public const int GLFW_OPENGL_API = 0x00030001;
    public const int GLFW_OPENGL_ES_API = 0x00030002;

    public const int GLFW_NO_ROBUSTNESS = 0;
    public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;
    public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;

    public const int GLFW_OPENGL_ANY_PROFILE = 0;
    public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;
    public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;

    public const int GLFW_CURSOR = 0x00033001;
    public const int GLFW_STICKY_KEYS = 0x00033002;
    public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
    public const int GLFW_LOCK_KEY_MODS = 0x00033004;
    public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;

    public const int GLFW_CURSOR_NORMAL = 0x00034001;
    public const int GLFW_CURSOR_HIDDEN = 0x00034002;
    public const int GLFW_CURSOR_DISABLED = 0x00034003;

    public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
    public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
    public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;

    public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;
    public const int GLFW_EGL_CONTEXT_API = 0x00036002;
    public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;

    public const int GLFW_ARROW_CURSOR = 0x00036001;
    public const int GLFW_IBEAM_CURSOR = 0x00036002;
    public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
    public const int GLFW_HAND_CURSOR = 0x00036004;
    public const int GLFW_HRESIZE_CURSOR = 0x00036005;
    public const int GLFW_VRESIZE_CURSOR = 0x00036006;
    public const int GLFW_CONNECTED = 0x00040001;
    public const int GLFW_DISCONNECTED = 0x00040002;

    public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x00050001;
    public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;
    public const int GLFW_COCOA_MENUBAR = 0x00051002;
    public const int GLFW_DONT_CARE = -1;

    // ************************************** //
    // Initialization version and error       //
    // ************************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwInit();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwTerminate();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwInitHint(int hint, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetVersionString();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetError(out IntPtr description);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWerrorfun(int error_code, string description);

    // ************************************** //
    // Monitor                                //
    // ************************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetMonitors(out int count);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetPrimaryMonitor();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetMonitorWorkarea(IntPtr monitor, out int xpos, out int ypos, out int width, out int height);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetMonitorContentScale(IntPtr monitor, out float xscale, out float yscale);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetMonitorName(IntPtr monitor);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetMonitorUserPointer(IntPtr monitor, IntPtr pointer);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetMonitorUserPointer(IntPtr monitor);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWmonitorfun(IntPtr monitor, int monitor_event);

    [StructLayout(LayoutKind.Sequential)]
    internal struct GLFWvidmode
    {
        internal int width;
        internal int height;
        internal int redBits;
        internal int greenBits;
        internal int blueBits;
        internal int refreshRate;
    }

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetVideoModes(IntPtr monitor, out int count);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetVideoMode(IntPtr monitor);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetGamma(IntPtr monitor, float gamma);

    [StructLayout(LayoutKind.Sequential)]
    internal struct GLFWgammaramp
    {
        internal IntPtr red;   // ushort[size]
        internal IntPtr green; // ushort[size]
        internal IntPtr blue;  // ushort[size]
        internal int size;
    }

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetGammaRamp(IntPtr monitor);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetGammaRamp(IntPtr monitor, GLFWgammaramp ramp);

    // ************************************** //
    // Window                                 //
    // ************************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwDefaultWindowHints();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwWindowHint(int hint, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwWindowHintString(int hint, [MarshalAs(UnmanagedType.LPStr)] string value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwCreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, IntPtr monitor, IntPtr share);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwDestroyWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwWindowShouldClose(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowShouldClose(IntPtr window, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowTitle(IntPtr window, [MarshalAs(UnmanagedType.LPStr)] string title);

    [StructLayout(LayoutKind.Sequential)]
    internal struct GLFWimage
    {
        internal int width;
        internal int height;
        internal IntPtr pixels; // pixel data left-to-right , top-to-bottom
    }

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowIcon(IntPtr window, int count, IntPtr images);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetWindowPos(IntPtr window, out int xpos, out int ypos);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowPos(IntPtr window, int xpos, int ypos);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetWindowSize(IntPtr window, out int width, out int height);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowAspectRatio(IntPtr window, int numer, int denom);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowSize(IntPtr window, int width, int height);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetFramebufferSize(IntPtr window, out int width, out int height);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetWindowContentScale(IntPtr window, out float xscale, out float yscale);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern float glfwGetWindowOpacity(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowOpacity(IntPtr window, float opacity);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwIconifyWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwRestoreWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwMaximizeWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwShowWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwHideWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwFocusWindow(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwRequestWindowAttention(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetWindowMonitor(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetWindowAttrib(IntPtr window, int attrib);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowAttrib(IntPtr window, int attrib, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetWindowUserPointer(IntPtr window, IntPtr pointer);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetWindowUserPointer(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowposfun glfwSetWindowPosCallback(IntPtr window, GLFWwindowposfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowposfun(IntPtr window, int xpos, int ypos);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowsizefun glfwSetWindowSizeCallback(IntPtr window, GLFWwindowsizefun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowsizefun(IntPtr window, int width, int height);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowclosefun glfwSetWindowCloseCallback(IntPtr window, GLFWwindowclosefun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowclosefun(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowrefreshfun glfwSetWindowRefreshCallback(IntPtr window, GLFWwindowrefreshfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowrefreshfun(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowfocusfun glfwSetWindowFocusCallback(IntPtr window, GLFWwindowfocusfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowfocusfun(IntPtr window, int focused);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowiconifyfun glfwSetWindowIconifyCallback(IntPtr window, GLFWwindowiconifyfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowiconifyfun(IntPtr window, int iconified);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowmaximizefun glfwSetWindowMaximizeCallback(IntPtr window, GLFWwindowmaximizefun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowmaximizefun(IntPtr window, int maximized);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWframebuffersizefun glfwSetFramebufferSizeCallback(IntPtr window, GLFWframebuffersizefun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWframebuffersizefun(IntPtr window, int width, int height);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWwindowcontentscalefun glfwSetWindowContentScaleCallback(IntPtr window, GLFWwindowcontentscalefun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWwindowcontentscalefun(IntPtr window, float xscale, float yscale);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwPollEvents();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwWaitEvents();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwWaitEventsTimeout(double timeout);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwPostEmptyEvent();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSwapBuffers(IntPtr window);

    // ************************************** //
    // Context                                //
    // ************************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwMakeContextCurrent(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetCurrentContext();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSwapInterval(int interval);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

    // ************************************** //
    // Input                                  //
    // ************************************** //

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetInputMode(IntPtr window, int mode);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetInputMode(IntPtr window, int mode, int value);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwRawMouseMotionSupported();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetKeyName(int key, int scancode);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetKeyScancode(int key);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetKey(IntPtr window, int key);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetMouseButton(IntPtr window, int button);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwGetCursorPos(IntPtr window, out double xpos, out double ypox);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetCursorPos(IntPtr window, double xpos, double ypox);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwCreateCursor(GLFWimage image, int xhot, int yhot);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwCreateStandardCursor(int shape);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwDestroyCursor(IntPtr cursor);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetCursor(IntPtr window, IntPtr cursor);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWkeyfun glfwSetKeyCallback(IntPtr window, GLFWkeyfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWkeyfun(IntPtr window, int key, int scancode, int action, int mods);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWcharfun glfwSetCharCallback(IntPtr window, GLFWcharfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWcharfun(IntPtr window, uint codepoint);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWcharmodsfun glfwSetCharModsCallback(IntPtr window, GLFWcharmodsfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWcharmodsfun(IntPtr window, uint codepoint, int mods);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWmousebuttonfun glfwSetMouseButtonCallback(IntPtr window, GLFWmousebuttonfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWmousebuttonfun(IntPtr window, int button, int action, int mods);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWcursorposfun glfwSetCursorPosCallback(IntPtr window, GLFWcursorposfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWcursorposfun(IntPtr window, double xpos, double ypos);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWcursorenterfun glfwSetCursorEnterCallback(IntPtr window, GLFWcursorenterfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWcursorenterfun(IntPtr window, int entered);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWscrollfun glfwSetScrollCallback(IntPtr window, GLFWscrollfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWscrollfun(IntPtr window, double xoffset, double yoffset);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWdropfun glfwSetDropCallback(IntPtr window, GLFWdropfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWdropfun(IntPtr window, int path_count, string[] paths);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwJoystickPresent(int jid);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetJoystickAxes(int jid, out int count);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetJoystickButtons(int jid, out int count);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetJoystickHats(int jid, out int count);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetJoystickName(int jid);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetJoystickGUID(int jid);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetJoystickUserPointer(int jid, IntPtr pointer);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetJoystickUserPointer(int jid);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwJoystickIsGamepad(int jid);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void GLFWjoystickfun(int jid, int callback_event);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwUpdateGamepadMappings([MarshalAs(UnmanagedType.LPStr)] string mapping_string);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetGamepadName(int jid);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glfwGetGamepadState(int jid, out GLFWgamepadstate state);

    [StructLayout(LayoutKind.Sequential)]
    internal struct GLFWgamepadstate
    {
        internal IntPtr buttons; // char[15] 
        internal IntPtr axes;    // float[6] 
    }

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetClipboardString(IntPtr intPtr, [MarshalAs(UnmanagedType.LPStr)] string clipboard_string);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr glfwGetClipboardString(IntPtr window);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern double glfwGetTime();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glfwSetTime(double time);

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern UInt64 glfwGetTimerValue();

    [DllImport(libraryPath, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern UInt64 glfwGetTimerFrequency();
}
