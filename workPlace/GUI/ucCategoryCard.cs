using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucCategoryCard : UserControl
    {
        public CategorySkill currentDisplayingCategory = null;

        public ucCategoryCard()
        {
            InitializeComponent();
        }

        public void DataSetter(CategorySkill cat)
        {
            currentDisplayingCategory = cat;
            lblCategory.Text = cat.Type;
        }
    }
}
