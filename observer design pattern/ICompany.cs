namespace observer_design_pattern
{
    public interface ICompany
    {
        void Attach(IParticipant participant);

        void Detach(IParticipant participant);

        void Notify();

    }
}
