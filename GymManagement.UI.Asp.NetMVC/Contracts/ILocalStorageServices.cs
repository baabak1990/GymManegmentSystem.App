﻿namespace GymManagement.UI.Asp.NetMVC.Contracts;

public interface ILocalStorageServices
{
    void ClearStorage(List<string> keys);
    bool Exist(string key);
    T GetStorageValue<T>(string key);
    void SetStorageValue<T>(string key, T value);
}