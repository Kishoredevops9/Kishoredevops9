using Xamarin.Forms;
namespace HealthClinic
{
    public abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel, new()
    {
        #region Constructors
        protected BaseContentPage(string pageTitle)
        {
            ViewModel = new T();
            BindingContext = ViewModel;
            Title = pageTitle;
            BackgroundColor = ColorConstants.Aqua;
        }
        #endregion

        #region Properties
        protected T ViewModel { get; }
        #endregion

        #region Methods
        protected abstract void SubscribeEventHandlers();

        protected abstract void UnsubscribeEventHandlers();

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SubscribeEventHandlers();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            UnsubscribeEventHandlers();
        }
        #endregion
    }
}
