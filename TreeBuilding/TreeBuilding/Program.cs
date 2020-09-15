using System;
using System.Collections.Generic;
using System.Linq;


namespace TreeBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = new[]
        {
            new TreeBuildingRecord { RecordId = 2, ParentId = 0 },
            new TreeBuildingRecord { RecordId = 3, ParentId = 2 },
            new TreeBuildingRecord { RecordId = 1, ParentId = 0 },
            new TreeBuildingRecord { RecordId = 0, ParentId = 0 }
        };
            var tree = TreeBuilder.BuildTree(records);
            foreach (var item in records)
            {
            Console.WriteLine(item.ParentId.ToString(), item.RecordId,"\n\n");

            }
        }
    }
    
public class TreeBuildingRecord
    {
        public int RecordId { get; set; }
        public int ParentId { get; set; }
    }

    public class Tree
    {
        public int Id { get; set; }
        public int ParentId { get; set; }

        public List<Tree> Children { get; set; }

        public bool IsLeaf => Children.Count == 0;
    }

    public static class TreeBuilder
    {
        public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
        {

            if (!Enumerable.Range(0, records.Count() ).SequenceEqual(records.Select(x => x.RecordId).OrderBy(x => x)))
                throw new ArgumentException();
            if (records.Where(x => (x.ParentId > x.RecordId)).Count() > 0)
                throw new ArgumentException();

            var trees = new List<Tree>();
            foreach (var record in records)
            {
                var t = new Tree { Children = new List<Tree>(), Id = record.RecordId, ParentId = record.ParentId };
                trees.Add(t);
            }

            for (int i = 1; i < trees.Count; i++)
            {
                var t = trees.First(x => x.Id == i);
                var parent = trees.First(x => x.Id == t.ParentId);
                parent.Children.Add(t);
            }

            Tree r = trees.First(t => t.Id == 0);
            return r;
        } }
        }
