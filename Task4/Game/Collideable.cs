namespace Task4.Game
{
    interface Collideable:GameObject, Renderable
    {
        void OnCollide(Collideable gameObject);
    }
}
