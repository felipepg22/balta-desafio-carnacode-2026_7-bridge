namespace DesignPatternChallenge
{
    public abstract class NotificationBase
    {
        protected string title;
        protected string content;

        public NotificationBase(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        public abstract void Render();
    }
}
