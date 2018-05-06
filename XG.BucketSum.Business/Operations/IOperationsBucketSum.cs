namespace XG.BucketSum.Business.Operations
{
    public interface IOperationsBucketSum
    {      
        int dimensions { get; set; }
        void setDimensions(int dimensions);
        void update(int x, int y, int z, int value);
        int query(int x1, int y1, int z1, int x2, int y2, int z2);
    }
}