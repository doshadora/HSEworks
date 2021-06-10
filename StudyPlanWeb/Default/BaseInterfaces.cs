namespace StudyPlanWeb.Default
{
    public interface IView
    {
        void Show();
        void Close();
        void Visible(bool state);
        void ShowError(string errorMessage);
    }

    public interface IPresenter
    {
        void Run();
    }
}