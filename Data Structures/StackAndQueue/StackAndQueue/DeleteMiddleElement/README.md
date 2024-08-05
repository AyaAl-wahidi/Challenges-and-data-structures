# StackWithDeleteMiddle

## Overview

`StackWithDeleteMiddle` is an extension of the `StackClass` that introduces the capability to delete the middle element from a stack. This functionality is particularly useful in scenarios where you need to maintain a stack's order while removing a specific element based on its position within the stack.

This implementation is part of a broader project focused on enhancing data structures and their functionalities in C#. It demonstrates how to manage stack operations efficiently, ensuring the stack remains in the correct order after the middle element is removed.

## Problem Domain

### Problem Statement

Stacks are a fundamental data structure used in various applications, such as expression evaluation, backtracking algorithms, and memory management. However, a common challenge arises when there is a need to remove the middle element from a stack without disrupting the stack's order.

The `StackWithDeleteMiddle` class addresses this challenge by providing a method to delete the middle element of a stack while maintaining its order. This is achieved using an auxiliary stack to temporarily hold elements and then restore them in their original sequence.

### Requirements

- **Create a class `StackWithDeleteMiddle` that extends the existing `StackClass`.**
- **Add a method `DeleteMiddle()` to remove the middle element of the stack.**
  - If the number of elements (`n`) is even, the middle position is `n/2 - 1`.
  - If the number of elements is odd, the middle position is `n/2`.
- **Use an additional stack to achieve this or another efficient solution.**
- **Ensure the stack remains in the correct order after the middle element is removed.**
- **Handle edge cases where the stack is empty or has only one element.**

## Whiteboard
![**Challenge Whiteboard**](/Assets/DeleteMiddleElementOfStack-WB.jpg)