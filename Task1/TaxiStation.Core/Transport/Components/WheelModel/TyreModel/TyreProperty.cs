namespace TaxiStation.Core.Transport.Components.WheelModel.TyreModel
{
    public struct TyreProperty
    {
        public TyreProperty(int width, int height, int radius, int loadIndex, int speedIndex)
        {
            Width = width;
            Height = height;
            Radius = radius;
            LoadIndex = loadIndex;
            SpeedIndex = speedIndex;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Radius { get; private set; }
        public int LoadIndex { get; private set; }
        public int SpeedIndex { get; private set; }
    }
}