namespace BasicWpfMVVM.Base
{
    public abstract class ViewModelBase : NotifyPropertyChangedBase
    {

        public void SetContext(object context)
        {
            OnSetContext(context);
        }

        protected virtual void OnSetContext(object context) { }        
    }
}
