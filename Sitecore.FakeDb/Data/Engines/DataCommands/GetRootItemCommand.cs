﻿namespace Sitecore.FakeDb.Data.Engines.DataCommands
{
  using Sitecore.Data.Items;

  public class GetRootItemCommand : Sitecore.Data.Engines.DataCommands.GetRootItemCommand
  {
    protected override Sitecore.Data.Engines.DataCommands.GetRootItemCommand CreateInstance()
    {
      return new GetRootItemCommand();
    }

    protected override Item DoExecute()
    {
      var dataStorage = this.Database.GetDataStorage();

      return dataStorage.Items[ItemIDs.RootID];
    }
  }
}