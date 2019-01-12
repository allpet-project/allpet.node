using System;
using allpet.peer.tcp;

namespace allpet.node
{
    public interface INode : IDisposable
    {
        void InitChain();//链初始化

        void StartNetwork();//启动网络


        UInt64 GetBlockCount();
        //获取节点对象
        allpet.peer.tcp.IPeer peer
        {
            get;
        }
    }
    public class Node
    {
        static INode CreateNode()
        {
            return new PeerNode();
        }
    }
    class PeerNode : INode
    {
        public IPeer peer => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ulong GetBlockCount()
        {
            throw new NotImplementedException();
        }

        public void InitChain()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {

        }

        public void StartNetwork()
        {
            throw new NotImplementedException();
        }
    }
}
