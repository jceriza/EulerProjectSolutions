using System;
using System.Collections.Generic;

namespace Utilities
{
    public class LatticePaths
    {
        private enum LatticePathDirection
        {
            Right,
            Down
        }

        private Stack<LatticePathDirection> _currentPath = new Stack<LatticePathDirection>();
        private Dictionary<int, List<Stack<LatticePathDirection>>> _correlations = new Dictionary<int, List<Stack<LatticePathDirection>>>();

        private readonly int _size;
        private int _numRights = 0;
        public LatticePaths(int size)
        {
            _size = size;
        }

        private bool IsComplete()
        {
            return _currentPath.Count == _size;
        }

        private void Down()
        {
            _currentPath.Push(LatticePathDirection.Down);
        }

        private void UndoStep()
        {
            if (_currentPath.Pop() == LatticePathDirection.Right)
            {
                _numRights--;
            }
        }

        private void Right()
        {
            _numRights++;
            _currentPath.Push(LatticePathDirection.Right);
        }

        private void GenerateHalfPaths()
        {
            if (IsComplete())
            {
                var pathToAdd = new Stack<LatticePathDirection>(_currentPath);

                if (_correlations.ContainsKey(_numRights))
                {
                    _correlations[_numRights].Add(new Stack<LatticePathDirection>(pathToAdd));
                }
                else
                {
                    _correlations[_numRights] = new List<Stack<LatticePathDirection>> { pathToAdd };
                }
            }
            else
            {
                Right();
                GenerateHalfPaths();
                UndoStep();
                Down();
                GenerateHalfPaths();
                UndoStep();
            }
        }
        private long CalculateNumberOfPaths()
        {
            long sum = 0;

            for (int numRights = 0; numRights <= _size; numRights++)
            {
                sum += (long)_correlations[numRights].Count * _correlations[_size - numRights].Count;
            }

            return sum;
        }

        private long NumberOfPaths()
        {
            GenerateHalfPaths();
            return CalculateNumberOfPaths();
        }

        public static long LatticePathsInASquareGrid(int size)
        {
            return new LatticePaths(size).NumberOfPaths();
        }
    }
}
