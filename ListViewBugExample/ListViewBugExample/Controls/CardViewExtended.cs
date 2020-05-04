using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveReportingXamarin.Controls
{
    public class CardViewExtended : PanCardView.CoverFlowView
    {
        
        private bool _isAnimating = false;
        
        //This function fades the view in and out, if allowed to trigger repeatedly it's possible for it to fade out and never fade back in.
        //Override to only allow it to fade if it's not doing so already.
        protected override async Task HardSetAsync()
        {
            if (!_isAnimating)
            {
                _isAnimating = true;
                await base.HardSetAsync();
                _isAnimating = false;
            }
        }
    }
}
