namespace TestTechnique_EONIX
{
    /// <summary>
    /// Interface pattern Observer (Suscriber)
    /// </summary>
    public interface ISpectator
    {
        void Update(IMonkey subject);
    }
}
