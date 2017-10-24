namespace Task4.Game
{
    interface Tangible
    {
        Position Position { get; set; }
        Dimension Size { get; set; }
        Rotation2D Rotation { get; set; }
        void Move(double dx, double dy);
        void Resize(double dx, double dy);
    }
}
