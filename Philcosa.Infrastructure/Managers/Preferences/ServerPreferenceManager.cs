﻿using System;
using System.Threading.Tasks;
using Philcosa.Shared.Settings;

namespace Philcosa.Infrastructure.Managers.Preferences
{
    //TODO - implement

    public class ServerPreferenceManager : IServerPreferenceManager
    {
        //private readonly ILocalStorageService _localStorageService;
        //private readonly ICurrentUserService _currentUserService;

        public ServerPreferenceManager(
            //ILocalStorageService localStorageService,
            //ICurrentUserService currentUserService
            )
        {
            //_localStorageService = localStorageService;
            //_currentUserService = currentUserService;
        }

        public async Task<IPreference> GetPreference()
        {
            throw new NotImplementedException();
            //return await _localStorageService.GetItemAsync<ServerPreference>("serverPreference") ?? new ServerPreference(_currentUserService);
        }

        public async Task SetPreference(IPreference preference)
        {
            throw new NotImplementedException();
            //await _localStorageService.SetItemAsync("serverPreference", preference as ServerPreference);
        }
    }
}
