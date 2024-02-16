using System;
using System.Collections.Generic;

namespace PocketGoogle;

public class Indexer : IIndexer
{
	public void Add(int id, string documentText)
	{
		throw new NotImplementedException();
	}

	public List<int> GetIds(string word)
	{
		throw new NotImplementedException();
	}

	public List<int> GetPositions(int id, string word)
	{
		throw new NotImplementedException();
	}

	public void Remove(int id)
	{
		throw new NotImplementedException();
	}
}