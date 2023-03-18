using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolskaZapiska;


internal sealed class LinkedNode<T>
{
    internal T Data { get; init; }
    internal LinkedNode<T> Link { get; set; }
    internal LinkedNode(T data = default) => Data = data;
}