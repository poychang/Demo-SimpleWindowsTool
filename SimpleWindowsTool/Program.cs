try
{
    var result = DoSomething();
    ShowMessage($"SimpleWindowsTool say: {result}");
}
catch (Exception ex)
{
    ShowMessage(ex.Message);
}

void ShowMessage(string msg)
{
    System.Windows.Forms.MessageBox.Show(msg, "Message");
}

string DoSomething()
{
    // TODO: do something...
    return "do something...";
}