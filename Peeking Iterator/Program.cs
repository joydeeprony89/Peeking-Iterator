using System;
using System.Collections.Generic;

namespace Peeking_Iterator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  class PeekingIterator
  {
    public IEnumerator<int> _iterator;
    public bool hasNext;
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator)
    {
      // initialize any member here.
      _iterator = iterator;
      hasNext = true;
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
      return _iterator.Current;
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
      var val = _iterator.Current;
      hasNext = _iterator.MoveNext();
      return val;
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
      return hasNext;
    }
  }
}
