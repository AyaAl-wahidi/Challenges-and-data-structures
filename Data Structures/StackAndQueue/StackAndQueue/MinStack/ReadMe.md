# Min Stack Challenge

# MinStack Implementation in C#

## Overview

This implementation of a MinStack in C# provides an efficient way to keep track of the minimum element in a stack at any given time. By maintaining an additional stack (`minStack`) that stores the minimum elements, the `GetMin()` operation can be performed in constant time, O(1). 

### Key Features:
- **Constant Time Minimum Retrieval**: The `GetMin()` method retrieves the current minimum element in the stack in O(1) time.
- **Dual Stack Mechanism**: A secondary stack (`minStack`) is used alongside the primary stack to store the minimum values.
- **Modular Design**: Each method (Push, Pop, Top, etc.) is designed to handle specific operations, ensuring clear and maintainable code.


## Whiteboard
![**Challenge Whiteboard**](https://github.com/AyaAl-wahidi/Challenges-and-data-structures/blob/main/Data%20Structures/StackAndQueue/StackAndQueue/MinStack/Assests/MinStackChallenge-WB.jpg)
