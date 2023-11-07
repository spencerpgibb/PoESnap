namespace PoESnap.Services.CharacterUpdateService
{
    public interface ICharacterUpdateService
    {
        void StartUpdates();
        void RecurringTask(Action action, int minutes, CancellationToken cancellationToken);
        void UpdateCharacters();
    }
}
