using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CouchComputerControl.UI
{
    public enum NiceKeys
    {
        [Description("Left mouse button")]
        LButton = Keys.LButton,
        [Description("RButton")]
        RButton = Keys.RButton,
        [Description("Cancel")]
        Cancel = Keys.Cancel,
        [Description("MButton")]
        MButton = Keys.MButton,
        [Description("XButton1")]
        XButton1 = Keys.XButton1,
        [Description("XButton2")]
        XButton2 = Keys.XButton2,
        [Description("Back")]
        Back = Keys.Back,
        [Description("Tab")]
        Tab = Keys.Tab,
        [Description("LineFeed")]
        LineFeed = Keys.LineFeed,
        [Description("Clear")]
        Clear = Keys.Clear,
        [Description("Return")]
        Return = Keys.Return,
        [Description("Enter")]
        Enter = Keys.Enter,
        [Description("ShiftKey")]
        ShiftKey = Keys.ShiftKey,
        [Description("ControlKey")]
        ControlKey = Keys.ControlKey,
        [Description("Menu")]
        Menu = Keys.Menu,
        [Description("Pause")]
        Pause = Keys.Pause,
        [Description("Capital")]
        Capital = Keys.Capital,
        [Description("CapsLock")]
        CapsLock = Keys.CapsLock,
        [Description("KanaMode")]
        KanaMode = Keys.KanaMode,
        [Description("HanguelMode")]
        HanguelMode = Keys.HanguelMode,
        [Description("HangulMode")]
        HangulMode = Keys.HangulMode,
        [Description("JunjaMode")]
        JunjaMode = Keys.JunjaMode,
        [Description("FinalMode")]
        FinalMode = Keys.FinalMode,
        [Description("HanjaMode")]
        HanjaMode = Keys.HanjaMode,
        [Description("KanjiMode")]
        KanjiMode = Keys.KanjiMode,
        [Description("Escape")]
        Escape = Keys.Escape,
        [Description("IMEConvert")]
        IMEConvert = Keys.IMEConvert,
        [Description("IMENonconvert")]
        IMENonconvert = Keys.IMENonconvert,
        [Description("IMEAccept")]
        IMEAccept = Keys.IMEAccept,
        [Description("IMEAceept")]
        IMEAceept = Keys.IMEAceept,
        [Description("IMEModeChange")]
        IMEModeChange = Keys.IMEModeChange,
        [Description("Space")]
        Space = Keys.Space,
        [Description("Prior")]
        Prior = Keys.Prior,
        [Description("PageUp")]
        PageUp = Keys.PageUp,
        [Description("Next")]
        Next = Keys.Next,
        [Description("PageDown")]
        PageDown = Keys.PageDown,
        [Description("End")]
        End = Keys.End,
        [Description("Home")]
        Home = Keys.Home,
        [Description("Left")]
        Left = Keys.Left,
        [Description("Up")]
        Up = Keys.Up,
        [Description("Right")]
        Right = Keys.Right,
        [Description("Down")]
        Down = Keys.Down,
        [Description("Select")]
        Select = Keys.Select,
        [Description("Print")]
        Print = Keys.Print,
        [Description("Execute")]
        Execute = Keys.Execute,
        [Description("Snapshot")]
        Snapshot = Keys.Snapshot,
        [Description("PrintScreen")]
        PrintScreen = Keys.PrintScreen,
        [Description("Insert")]
        Insert = Keys.Insert,
        [Description("Delete")]
        Delete = Keys.Delete,
        [Description("Help")]
        Help = Keys.Help,
        [Description("D0")]
        D0 = Keys.D0,
        [Description("D1")]
        D1 = Keys.D1,
        [Description("D2")]
        D2 = Keys.D2,
        [Description("D3")]
        D3 = Keys.D3,
        [Description("D4")]
        D4 = Keys.D4,
        [Description("D5")]
        D5 = Keys.D5,
        [Description("D6")]
        D6 = Keys.D6,
        [Description("D7")]
        D7 = Keys.D7,
        [Description("D8")]
        D8 = Keys.D8,
        [Description("D9")]
        D9 = Keys.D9,
        [Description("A")]
        A = Keys.A,
        [Description("B")]
        B = Keys.B,
        [Description("C")]
        C = Keys.C,
        [Description("D")]
        D = Keys.D,
        [Description("E")]
        E = Keys.E,
        [Description("F")]
        F = Keys.F,
        [Description("G")]
        G = Keys.G,
        [Description("H")]
        H = Keys.H,
        [Description("I")]
        I = Keys.I,
        [Description("J")]
        J = Keys.J,
        [Description("K")]
        K = Keys.K,
        [Description("L")]
        L = Keys.L,
        [Description("M")]
        M = Keys.M,
        [Description("N")]
        N = Keys.N,
        [Description("O")]
        O = Keys.O,
        [Description("P")]
        P = Keys.P,
        [Description("Q")]
        Q = Keys.Q,
        [Description("R")]
        R = Keys.R,
        [Description("S")]
        S = Keys.S,
        [Description("T")]
        T = Keys.T,
        [Description("U")]
        U = Keys.U,
        [Description("V")]
        V = Keys.V,
        [Description("W")]
        W = Keys.W,
        [Description("X")]
        X = Keys.X,
        [Description("Y")]
        Y = Keys.Y,
        [Description("Z")]
        Z = Keys.Z,
        [Description("LWin")]
        LWin = Keys.LWin,
        [Description("RWin")]
        RWin = Keys.RWin,
        [Description("Apps")]
        Apps = Keys.Apps,
        [Description("Sleep")]
        Sleep = Keys.Sleep,
        [Description("NumPad0")]
        NumPad0 = Keys.NumPad0,
        [Description("NumPad1")]
        NumPad1 = Keys.NumPad1,
        [Description("NumPad2")]
        NumPad2 = Keys.NumPad2,
        [Description("NumPad3")]
        NumPad3 = Keys.NumPad3,
        [Description("NumPad4")]
        NumPad4 = Keys.NumPad4,
        [Description("NumPad5")]
        NumPad5 = Keys.NumPad5,
        [Description("NumPad6")]
        NumPad6 = Keys.NumPad6,
        [Description("NumPad7")]
        NumPad7 = Keys.NumPad7,
        [Description("NumPad8")]
        NumPad8 = Keys.NumPad8,
        [Description("NumPad9")]
        NumPad9 = Keys.NumPad9,
        [Description("Multiply")]
        Multiply = Keys.Multiply,
        [Description("Add")]
        Add = Keys.Add,
        [Description("Separator")]
        Separator = Keys.Separator,
        [Description("Subtract")]
        Subtract = Keys.Subtract,
        [Description("Decimal")]
        Decimal = Keys.Decimal,
        [Description("Divide")]
        Divide = Keys.Divide,
        [Description("F1")]
        F1 = Keys.F1,
        [Description("F2")]
        F2 = Keys.F2,
        [Description("F3")]
        F3 = Keys.F3,
        [Description("F4")]
        F4 = Keys.F4,
        [Description("F5")]
        F5 = Keys.F5,
        [Description("F6")]
        F6 = Keys.F6,
        [Description("F7")]
        F7 = Keys.F7,
        [Description("F8")]
        F8 = Keys.F8,
        [Description("F9")]
        F9 = Keys.F9,
        [Description("F10")]
        F10 = Keys.F10,
        [Description("F11")]
        F11 = Keys.F11,
        [Description("F12")]
        F12 = Keys.F12,
        [Description("F13")]
        F13 = Keys.F13,
        [Description("F14")]
        F14 = Keys.F14,
        [Description("F15")]
        F15 = Keys.F15,
        [Description("F16")]
        F16 = Keys.F16,
        [Description("F17")]
        F17 = Keys.F17,
        [Description("F18")]
        F18 = Keys.F18,
        [Description("F19")]
        F19 = Keys.F19,
        [Description("F20")]
        F20 = Keys.F20,
        [Description("F21")]
        F21 = Keys.F21,
        [Description("F22")]
        F22 = Keys.F22,
        [Description("F23")]
        F23 = Keys.F23,
        [Description("F24")]
        F24 = Keys.F24,
        [Description("NumLock")]
        NumLock = Keys.NumLock,
        [Description("Scroll")]
        Scroll = Keys.Scroll,
        [Description("LShiftKey")]
        LShiftKey = Keys.LShiftKey,
        [Description("RShiftKey")]
        RShiftKey = Keys.RShiftKey,
        [Description("LControlKey")]
        LControlKey = Keys.LControlKey,
        [Description("RControlKey")]
        RControlKey = Keys.RControlKey,
        [Description("LMenu")]
        LMenu = Keys.LMenu,
        [Description("RMenu")]
        RMenu = Keys.RMenu,
        [Description("BrowserBack")]
        BrowserBack = Keys.BrowserBack,
        [Description("BrowserForward")]
        BrowserForward = Keys.BrowserForward,
        [Description("BrowserRefresh")]
        BrowserRefresh = Keys.BrowserRefresh,
        [Description("BrowserStop")]
        BrowserStop = Keys.BrowserStop,
        [Description("BrowserSearch")]
        BrowserSearch = Keys.BrowserSearch,
        [Description("BrowserFavorites")]
        BrowserFavorites = Keys.BrowserFavorites,
        [Description("BrowserHome")]
        BrowserHome = Keys.BrowserHome,
        [Description("VolumeMute")]
        VolumeMute = Keys.VolumeMute,
        [Description("VolumeDown")]
        VolumeDown = Keys.VolumeDown,
        [Description("VolumeUp")]
        VolumeUp = Keys.VolumeUp,
        [Description("MediaNextTrack")]
        MediaNextTrack = Keys.MediaNextTrack,
        [Description("MediaPreviousTrack")]
        MediaPreviousTrack = Keys.MediaPreviousTrack,
        [Description("MediaStop")]
        MediaStop = Keys.MediaStop,
        [Description("MediaPlayPause")]
        MediaPlayPause = Keys.MediaPlayPause,
        [Description("LaunchMail")]
        LaunchMail = Keys.LaunchMail,
        [Description("SelectMedia")]
        SelectMedia = Keys.SelectMedia,
        [Description("LaunchApplication1")]
        LaunchApplication1 = Keys.LaunchApplication1,
        [Description("LaunchApplication2")]
        LaunchApplication2 = Keys.LaunchApplication2,
        [Description("OemSemicolon")]
        OemSemicolon = Keys.OemSemicolon,
        [Description("Oem1")]
        Oem1 = Keys.Oem1,
        [Description("Oemplus")]
        Oemplus = Keys.Oemplus,
        [Description("Oemcomma")]
        Oemcomma = Keys.Oemcomma,
        [Description("OemMinus")]
        OemMinus = Keys.OemMinus,
        [Description("OemPeriod")]
        OemPeriod = Keys.OemPeriod,
        [Description("OemQuestion")]
        OemQuestion = Keys.OemQuestion,
        [Description("Oem2")]
        Oem2 = Keys.Oem2,
        [Description("Oemtilde")]
        Oemtilde = Keys.Oemtilde,
        [Description("Oem3")]
        Oem3 = Keys.Oem3,
        [Description("OemOpenBrackets")]
        OemOpenBrackets = Keys.OemOpenBrackets,
        [Description("Oem4")]
        Oem4 = Keys.Oem4,
        [Description("OemPipe")]
        OemPipe = Keys.OemPipe,
        [Description("Oem5")]
        Oem5 = Keys.Oem5,
        [Description("OemCloseBrackets")]
        OemCloseBrackets = Keys.OemCloseBrackets,
        [Description("Oem6")]
        Oem6 = Keys.Oem6,
        [Description("OemQuotes")]
        OemQuotes = Keys.OemQuotes,
        [Description("Oem7")]
        Oem7 = Keys.Oem7,
        [Description("Oem8")]
        Oem8 = Keys.Oem8,
        [Description("OemBackslash")]
        OemBackslash = Keys.OemBackslash,
        [Description("Oem102")]
        Oem102 = Keys.Oem102,
        [Description("ProcessKey")]
        ProcessKey = Keys.ProcessKey,
        [Description("Packet")]
        Packet = Keys.Packet,
        [Description("Attn")]
        Attn = Keys.Attn,
        [Description("Crsel")]
        Crsel = Keys.Crsel,
        [Description("Exsel")]
        Exsel = Keys.Exsel,
        [Description("EraseEof")]
        EraseEof = Keys.EraseEof,
        [Description("Play")]
        Play = Keys.Play,
        [Description("Zoom")]
        Zoom = Keys.Zoom,
        [Description("NoName")]
        NoName = Keys.NoName,
        [Description("Pa1")]
        Pa1 = Keys.Pa1,
        [Description("OemClear")]
        OemClear = Keys.OemClear,
        [Description("KeyCode")]
        KeyCode = Keys.KeyCode,
        [Description("Shift")]
        Shift = Keys.Shift,
        [Description("Control")]
        Control = Keys.Control,
        [Description("Alt")]
        Alt = Keys.Alt
    }
}
