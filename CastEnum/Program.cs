// See https://aka.ms/new-console-template for more information

using RotateFlipTypes = CastEnum.NewEnum.RotateFlipTypes;
using RotateFlipType = CastEnum.OriginalEnum.RotateFlipType;

var val = 10;

var rot = RotateFlipTypes.None;

if (val == 3 || val == 4)
    rot = RotateFlipTypes.Rotate180FlipNone;
else if (val == 5 || val == 6)
    rot = RotateFlipTypes.Rotate90FlipNone;
else if (val == 7 || val == 8)
    rot = RotateFlipTypes.Rotate270FlipNone;


Console.WriteLine($"New Value is {(RotateFlipType)rot}");
