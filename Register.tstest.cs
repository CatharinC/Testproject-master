using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestProject1
{

    public class Register : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Navigate to : 'http://automationpractice.com'")]
        public void Register_CodedStep()
        {
            // Navigate to : 'http://automationpractice.com'
            ActiveBrowser.NavigateTo("http://automationpractice.com");
            ActiveBrowser.Window.SetFocus();
            Pages.MyStore.LogInToLink.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            Pages.MyStore.LogInToLink.MouseClick();

            //ActiveBrowser.WaitForUrl("http://automationpractice.com",true,50000);
        }
    
        [CodedStep(@"Click 'LogInToLink'")]
        public void Register_CodedStep1()
        {
            // Click 'LogInToLink'
            ActiveBrowser.Window.SetFocus();
            Pages.MyStore.LogInToLink.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            Pages.MyStore.LogInToLink.MouseClick();
            
        }
    }
}
