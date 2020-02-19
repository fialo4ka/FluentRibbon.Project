using Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        List<GISMenuItem> menuTabNames = new List<GISMenuItem>
        {
            new GISMenuItem()
            {
                Name = "Menu 1",
                Children =  new List<GISMenuItem>
                                    {
                                        new GISMenuItem()
                                        {
                                            Name = "group 1",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                        new GISMenuItem()
                                        {
                                            Name = "group 2",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                        new GISMenuItem()
                                        {
                                            Name = "group 1",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                    }
            },
            new GISMenuItem()
            {
                Name = "Menu group 2",
                Children =  new List<GISMenuItem>
                                    {
                                        new GISMenuItem()
                                        {
                                            Name = "group 1",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                        new GISMenuItem()
                                        {
                                            Name = "group 2",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                        new GISMenuItem()
                                        {
                                            Name = "group 1",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                    }
            },
            new GISMenuItem()
            {
                Name = "Menu group 3",
                                Children =  new List<GISMenuItem>
                                    {
                                        new GISMenuItem()
                                        {
                                            Name = "group 1",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                        new GISMenuItem()
                                        {
                                            Name = "group 2",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                    }
                                        },
                                        new GISMenuItem()
                                        {
                                            Name = "group 1",
                                            LargeIcon = "new",
                                            SmallIcon = "Zoom",
                                            Children =new List<GISMenuItem>
                                                                    {
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "button 1",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 2",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom"
                                                                        },
                                                                        new GISMenuItem()
                                                                        {
                                                                            Name = "group 3",
                                                                            LargeIcon = "new",
                                                                            SmallIcon = "Zoom",
                                                                            Children =new List<GISMenuItem>
                                                                            {
                                                                                new GISMenuItem()
                                                                                {
                                                                                    Name = "button 1",
                                                                                    LargeIcon = "new",
                                                                                    SmallIcon = "Zoom",
                                                                                },
                                                                                new GISMenuItem()
                                                                                {
                                                                                    Name = "group 2",
                                                                                    LargeIcon = "new",
                                                                                    SmallIcon = "Zoom"
                                                                                },
                                                                                new GISMenuItem()
                                                                                {
                                                                                    Name = "group 3",
                                                                                    LargeIcon = "new",
                                                                                    SmallIcon = "Zoom"

                                                                                },
                                                                            }
                                                                        },
                                                                    }
                                        },
                                    }
            },
        };

        public MainWindow()
        {
            InitializeComponent();
            InitializeMenuStructure();
        }

        private void InitializeMenuStructure()
        {
            int ribbonGroupCount = 0;
            foreach (var menu in menuTabNames)
            {
                GISRibbonTabItem newTab = new GISRibbonTabItem() { Header = menu.Name };
                ribbonMain.Tabs.Add(newTab);
                foreach (var childMenu in menu.Children)
                {
                    var ribbonGroupName = "Grp" + ribbonGroupCount++;
                    RibbonGroupBox newGroup = new RibbonGroupBox
                    {
                        Header = childMenu.Name,
                        Name = ribbonGroupName,
                        Icon = string.IsNullOrEmpty(childMenu.LargeIcon) ? null : Application.Current.FindResource(childMenu.LargeIcon)
                    };

                    newTab.Groups.Add(newGroup);
                    newTab.ReduceOrder = string.Join(",", newTab.ReduceOrder, ribbonGroupName, ribbonGroupName);

                    if (childMenu.Children != null)
                    {
                        var hasSingleChild = childMenu.Children.Count == 1;

                        if (!hasSingleChild)
                        {
                            newTab.ReduceOrder = string.Join(",", newTab.ReduceOrder, ribbonGroupName);
                        }

                        foreach (var subItem in childMenu.Children)
                        {
                            newGroup.Items.Add(CreateChild(subItem, hasSingleChild));
                        }
                    }
                }
            }
        }

        private object CreateChild(GISMenuItem menuItem, bool isSingleChild)
        {
            if (menuItem.Children == null)
            {
                return CreateRibbonButton(menuItem, isSingleChild);
            }
            else
            {
                Fluent.MenuItem item = new Fluent.MenuItem { Header = menuItem.Name };

                foreach (var subItem in menuItem.Children)
                {
                    item.Items.Add(CreateChild(subItem, menuItem.Children.Count == 1));
                }
                return item;
            }
        }

        private GISRibbonButton CreateRibbonButton(GISMenuItem menuItem, bool isSingleButton)
        {
            bool canBeSmall = false;
            bool canBeLarge = isSingleButton;
            GISRibbonButton newButton = new GISRibbonButton
            {
                Header = menuItem.Name,
                HorizontalAlignment = HorizontalAlignment.Stretch
            };

            if (!string.IsNullOrEmpty(menuItem.SmallIcon))
            {
                newButton.Icon = Application.Current.FindResource(menuItem.SmallIcon);
                canBeSmall = true;
            }

            if (!string.IsNullOrEmpty(menuItem.LargeIcon))
            {
                newButton.LargeIcon = Application.Current.FindResource(menuItem.LargeIcon);
                canBeLarge = true;
            }

            newButton.SizeDefinition = new RibbonControlSizeDefinition(
                canBeLarge ? RibbonControlSize.Large : RibbonControlSize.Middle,
                isSingleButton ? RibbonControlSize.Large : RibbonControlSize.Middle,
                isSingleButton ? RibbonControlSize.Large : canBeSmall ? RibbonControlSize.Small : RibbonControlSize.Middle);
            return newButton;
        }

    }

    class GISMenuItem
    {
        public string Name { get; set; }
        public string SmallIcon { get; set; }
        public string LargeIcon { get; set; }
        public List<GISMenuItem> Children { get; set; }
    }
}
