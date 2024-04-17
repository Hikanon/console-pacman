namespace study.Entity
{

    internal abstract class Event
    {

        public abstract void DoEvent();
    }

    internal class Move : Event
    {

        public override void DoEvent()
        {
            throw new NotImplementedException();
        }
    }

}