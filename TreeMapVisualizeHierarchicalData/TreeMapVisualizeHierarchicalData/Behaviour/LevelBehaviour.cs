using Syncfusion.Maui.TreeMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeMapVisualizeHierarchicalData
{
    public class LevelBehavior : Behavior<ContentPage>
    {
        #region Fields

        /// <summary>
        /// The tree map instance.
        /// </summary>
        private SfTreeMap? treeMap;

        /// <summary>
        /// The radio button for the no group level option.
        /// </summary>
        private RadioButton? optionButton;

        /// <summary>
        /// The radio button for the group level option.
        /// </summary>
        private RadioButton? groupOptionButton;

        #endregion

        #region Override methods

        /// <summary>
        /// Invoked when behavior is attached to a view.
        /// </summary>
        /// <param name="sampleView">The sample view to which the behavior is attached.</param>
        protected override void OnAttachedTo(ContentPage sampleView)
        {
            base.OnAttachedTo(sampleView);

            this.treeMap = sampleView.FindByName<SfTreeMap>("treeMap");
        }

        /// <summary>
        /// Invoked when behavior is detached from a view.
        /// </summary>
        /// <param name="sampleView">The sample view from which the behavior is detached.</param>
        protected override void OnDetachingFrom(ContentPage sampleView)
        {
            base.OnDetachingFrom(sampleView);
            if (this.treeMap != null)
            {
                this.treeMap = null;
            }
           
        }

        #endregion
       
    }
}
