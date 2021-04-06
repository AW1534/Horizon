using System;
using CefSharp;
using System.Windows.Forms;
using Horizon;

public class MyCustomMenuHandler : IContextMenuHandler
{

    string defaultEngine = "DuckDuckGo";
    public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
    {
        // Remove any existent option using the Clear method of the model
        //
        //model.Clear();

        Console.WriteLine("Context menu opened !");

        // You can add a separator in case that there are more items on the list
        if (model.Count > 0)
        {
            model.AddSeparator();
        }


        // Add a new item to the list using the AddItem method of the model
        model.AddItem((CefMenuCommand)26500, "Search " + defaultEngine);
        model.AddSeparator();
        model.AddItem((CefMenuCommand)26501, "Show DevTools");
        model.AddItem((CefMenuCommand)26502, "Close DevTools");
        model.AddSeparator();
        model.AddItem((CefMenuCommand)26503, "Show Theme Menu");
        model.AddItem((CefMenuCommand)26503, "print");



        // Add a separator
        model.AddSeparator();

        // Add another example item
        model.AddItem((CefMenuCommand)26503, "Display alert message");
    }

    public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
    {
        if (commandId == (CefMenuCommand)26500)
        {
            MessageBox.Show("(Not Implemented)");
            return true;
        }
        // React to the first ID (show dev tools method)
        if (commandId == (CefMenuCommand)26501)
        {
            browser.GetHost().ShowDevTools();
            return true;
        }

        // React to the second ID (show dev tools method)
        if (commandId == (CefMenuCommand)26502)
        {
            browser.GetHost().CloseDevTools();
            return true;
        }

        // Any new item should be handled through a new if statement


        // Return false should ignore the selected option of the user !
        return false;
    }

    public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
    {

    }

    public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
    {
        return false;
    }
}