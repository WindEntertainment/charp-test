namespace Wind {
  public partial class InputSystem {
    public enum Keycode {
      Unknown = 0,
      K_Return = 13,
      K_Escape = 27,
      K_Backspace = 8,
      K_Tab = 9,
      K_Space = 32,
      K_Exclaim = 33,
      K_QuoteDbl = 34,
      K_Hash = 35,
      K_Percent = 37,
      K_Dollar = 36,
      K_Ampersand = 38,
      K_Quote = 39,
      K_LeftParen = 40,
      K_RightParen = 41,
      K_Asterisk = 42,
      K_Plus = 43,
      K_Comma = 44,
      K_Minus = 45,
      K_Period = 46,
      K_Slash = 47,
      K_0 = 48,
      K_1 = 49,
      K_2 = 50,
      K_3 = 51,
      K_4 = 52,
      K_5 = 53,
      K_6 = 54,
      K_7 = 55,
      K_8 = 56,
      K_9 = 57,
      K_Colon = 58,
      K_Semicolon = 59,
      K_Less = 60,
      K_Equals = 61,
      K_Greater = 62,
      K_Question = 63,
      K_At = 64,
      K_LeftBracket = 91,
      K_Backslash = 92,
      K_RightBracket = 93,
      K_Caret = 94,
      K_Underscore = 95,
      K_BackQuote = 96,
      K_A = 97,
      K_B = 98,
      K_C = 99,
      K_D = 100,
      K_E = 101,
      K_F = 102,
      K_G = 103,
      K_H = 104,
      K_I = 105,
      K_J = 106,
      K_K = 107,
      K_L = 108,
      K_M = 109,
      K_N = 110,
      K_O = 111,
      K_P = 112,
      K_Q = 113,
      K_R = 114,
      K_S = 115,
      K_T = 116,
      K_U = 117,
      K_V = 118,
      K_W = 119,
      K_X = 120,
      K_Y = 121,
      K_Z = 122,
      K_CapsLock = 1073741881,
      K_F1 = 1073741882,
      K_F2 = 1073741883,
      K_F3 = 1073741884,
      K_F4 = 1073741885,
      K_F5 = 1073741886,
      K_F6 = 1073741887,
      K_F7 = 1073741888,
      K_F8 = 1073741889,
      K_F9 = 1073741890,
      K_F10 = 1073741891,
      K_F11 = 1073741892,
      K_F12 = 1073741893,
      K_PrintScreen = 1073741894,
      K_ScrollLock = 1073741895,
      K_Pause = 1073741896,
      K_Insert = 1073741897,
      K_Home = 1073741898,
      K_PageUp = 1073741899,
      K_Delete = 127,
      K_End = 1073741901,
      K_PageDown = 1073741902,
      K_Right = 1073741903,
      K_Left = 1073741904,
      K_Down = 1073741905,
      K_Up = 1073741906,
      K_NumLockClear = 1073741907,
      K_KpDivide = 1073741908,
      K_KpMultiply = 1073741909,
      K_KpMinus = 1073741910,
      K_KpPlus = 1073741911,
      K_KpEnter = 1073741912,
      K_Kp1 = 1073741913,
      K_Kp2 = 1073741914,
      K_Kp3 = 1073741915,
      K_Kp4 = 1073741916,
      K_Kp5 = 1073741917,
      K_Kp6 = 1073741918,
      K_Kp7 = 1073741919,
      K_Kp8 = 1073741920,
      K_Kp9 = 1073741921,
      K_Kp0 = 1073741922,
      K_KpPeriod = 1073741923,
      K_Application = 1073741925,
      K_Power = 1073741926,
      K_KpEquals = 1073741927,
      K_F13 = 1073741928,
      K_F14 = 1073741929,
      K_F15 = 1073741930,
      K_F16 = 1073741931,
      K_F17 = 1073741932,
      K_F18 = 1073741933,
      K_F19 = 1073741934,
      K_F20 = 1073741935,
      K_F21 = 1073741936,
      K_F22 = 1073741937,
      K_F23 = 1073741938,
      K_F24 = 1073741939,
      K_Execute = 1073741940,
      K_Help = 1073741941,
      K_Menu = 1073741942,
      K_Select = 1073741943,
      K_Stop = 1073741944,
      K_Again = 1073741945,
      K_Undo = 1073741946,
      K_Cut = 1073741947,
      K_Copy = 1073741948,
      K_Paste = 1073741949,
      K_Find = 1073741950,
      K_Mute = 1073741951,
      K_VolumeUp = 1073741952,
      K_VolumeDown = 1073741953,
      K_KpComma = 1073741957,
      K_KpEqualsAs400 = 1073741958,
      K_AltErase = 1073741977,
      K_SysReq = 1073741978,
      K_Cancel = 1073741979,
      K_Clear = 1073741980,
      K_Prior = 1073741981,
      K_Return2 = 1073741982,
      K_Separator = 1073741983,
      K_Out = 1073741984,
      K_Oper = 1073741985,
      K_ClearAgain = 1073741986,
      K_Crsel = 1073741987,
      K_Exsel = 1073741988,
      K_Kp00 = 1073742000,
      K_Kp000 = 1073742001,
      K_ThousandsSeparator = 1073742002,
      K_DecimalSeparator = 1073742003,
      K_CurrencyUnit = 1073742004,
      K_CurrencySubUnit = 1073742005,
      K_KpLeftParen = 1073742006,
      K_KpRightParen = 1073742007,
      K_KpLeftBrace = 1073742008,
      K_KpRightBrace = 1073742009,
      K_KpTab = 1073742010,
      K_KpBackspace = 1073742011,
      K_KpA = 1073742012,
      K_KpB = 1073742013,
      K_KpC = 1073742014,
      K_KpD = 1073742015,
      K_KpE = 1073742016,
      K_KpF = 1073742017,
      K_KpXor = 1073742018,
      K_KpPower = 1073742019,
      K_KpPercent = 1073742020,
      K_KpLess = 1073742021,
      K_KpGreater = 1073742022,
      K_KpAmpersand = 1073742023,
      K_KpDblAmpersand = 1073742024,
      K_KpVerticalBar = 1073742025,
      K_KpDblVerticalBar = 1073742026,
      K_KpColon = 1073742027,
      K_KpHash = 1073742028,
      K_KpSpace = 1073742029,
      K_KpAt = 1073742030,
      K_KpExclam = 1073742031,
      K_KpMemStore = 1073742032,
      K_KpMemRecall = 1073742033,
      K_KpMemClear = 1073742034,
      K_KpMemAdd = 1073742035,
      K_KpMemSubtract = 1073742036,
      K_KpMemMultiply = 1073742037,
      K_KpMemDivide = 1073742038,
      K_KpPlusMinus = 1073742039,
      K_KpClear = 1073742040,
      K_KpClearEntry = 1073742041,
      K_KpBinary = 1073742042,
      K_KpOctal = 1073742043,
      K_KpDecimal = 1073742044,
      K_KpHexadecimal = 1073742045,
      K_LeftCtrl = 1073742048,
      K_LeftShift = 1073742049,
      K_LeftAlt = 1073742050,
      K_LeftGui = 1073742051,
      K_RightCtrl = 1073742052,
      K_RightShift = 1073742053,
      K_RightAlt = 1073742054,
      K_RightGui = 1073742055,
      K_Mode = 1073742081,
      K_AudioNext = 1073742082,
      K_AudioPrev = 1073742083,
      K_AudioStop = 1073742084,
      K_AudioPlay = 1073742085,
      K_AudioMute = 1073742086,
      K_MediaSelect = 1073742087,
      K_Www = 1073742088,
      K_Mail = 1073742089,
      K_Calculator = 1073742090,
      K_Computer = 1073742091,
      K_AcSearch = 1073742092,
      K_AcHome = 1073742093,
      K_AcBack = 1073742094,
      K_AcForward = 1073742095,
      K_AcStop = 1073742096,
      K_AcRefresh = 1073742097,
      K_AcBookmarks = 1073742098,
      K_BrightnessDown = 1073742099,
      K_BrightnessUp = 1073742100,
      K_DisplaySwitch = 1073742101,
      K_KbdillumToggle = 1073742102,
      K_KbdillumDown = 1073742103,
      K_KbdillumuUp = 1073742104,
      K_Eject = 1073742105,
      K_Sleep = 1073742106,
      //
      M_ButtonLeft,
      M_ButtonRight,
      M_ButtonMiddle,
      //
      M_Move,
      M_ScrollDown,
      M_ScrollUp,
      M_Scroll,
      //
      K_AllKeys,
      K_AllChars,
      M_AllKeys,
      M_AllEvents,
      AllEvents,
    };
  };
}