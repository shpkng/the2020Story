﻿// Author: wuchenyang(shpkng@gmail.com)

public interface DataManagerBase<T> where T : IDatum
{
    public bool Get(uint id, out T value);
    public bool Remove(uint id);
    public bool Update(uint id);
    public bool Reset(uint id);
}