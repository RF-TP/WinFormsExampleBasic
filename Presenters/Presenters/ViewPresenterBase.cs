namespace Presenters.Presenters
{
    public abstract class ViewPresenterBase<TView>
    {
        protected TView _view;

        public ViewPresenterBase(TView view)
        {
            _view = view;
        }

        public abstract void InitView();
    }
}
