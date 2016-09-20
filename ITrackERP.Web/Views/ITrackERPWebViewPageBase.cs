using Abp.Web.Mvc.Views;

namespace ITrackERP.Web.Views
{
    public abstract class ITrackERPWebViewPageBase : ITrackERPWebViewPageBase<dynamic>
    {

    }

    public abstract class ITrackERPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ITrackERPWebViewPageBase()
        {
            LocalizationSourceName = ITrackERPConsts.LocalizationSourceName;
        }
    }
}