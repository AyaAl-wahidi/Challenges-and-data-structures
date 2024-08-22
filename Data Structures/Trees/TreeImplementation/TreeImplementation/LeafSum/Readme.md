## Binary Tree - Sum of leaf nodes

## Overview

The `LeafSum` method calculates the sum of all leaf nodes in a binary tree. A leaf node is a node without children. The method uses a recursive approach to traverse the tree, checking each node to determine if it's a leaf. If it is, the node's value is added to the sum. If not, the method recursively sums the leaf nodes of the left and right subtrees. The method handles edge cases, such as an empty tree (returns `0`) and a tree with only one node (returns the node's value). The time complexity is `O(n)`, and the space complexity is `O(h)`.


## Binary Tree - Sum of leaf nodes Whiteboard
![**Challenge Whiteboard**](/Assets/LeafSumTree-WB.jpg)