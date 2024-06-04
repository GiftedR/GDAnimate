using Godot;
using Godot.Collections;
using System;

static public partial class AppPreferences{
    // region PREFs
    static public uint IconSize = 16;
    static private string PrefBase = "7f7f7f";
    static private string[] ColorTransparencies = { "00", "1C", "39", "55", "71", "8E", "AA", "C6", "E3", "ff" };

    public static Color GetColor(int opacity){
        return Color.FromHtml($"{PrefBase}{ColorTransparencies[opacity]}");
    }

    public static void SetColor(Color color){
        PrefBase = color.ToHtml(false);
    }

    // endregion
}