namespace Task4.Game
{
    interface Renderable: Tangible
    {
        Texture GetTexture();
        bool IsVisible();
        void SetVisibility(bool visible);
    }
}
