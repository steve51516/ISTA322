# C# Programming Homework 16

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
```cs
(bits & (1 << 5)) != 0

// Below is the bitwise complement operator
uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint b = ~a;
Console.WriteLine(Convert.ToString(b, toBase: 2));
// Output:
// 11110000111100001111000011110011

// Below is the left shift operator
uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");

uint y = x << 4;
Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
// Output:
// Before: 11001001000000000000000000010001
// After:  10010000000000000000000100010000

// Below is the logical AND & operator
uint a = 0b_1111_1000;
uint b = 0b_1001_1101;
uint c = a & b;
Console.WriteLine(Convert.ToString(c, toBase: 2));
// Output:
// 10011000

// Below is the logical OR | operator
uint a = 0b_1111_1000;
uint b = 0b_0001_1100;
uint c = a ^ b;
Console.WriteLine(Convert.ToString(c, toBase: 2));
// Output:
// 11100100

// Compound assignment logical &
uint a = 0b_1111_1000;
a &= 0b_1001_1101;
Display(a);  // output: 10011000
```
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie C# code.
   - Yes.
```cs
uint y = x >> 2;
Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2), 4}");
// Output:
// Before: 1001
// After:    10
```
3. Explain in detail this code: `bits & (1 << index);`.
  - The bits in 1 are shifted to the left by the value of `index`.
  - The bits that match between the expression and `bits` will be returned.
4. Explain in detail this code: `bits |= (1 << index);`.
  - 1 is shifted the left by the value of `index`.
  - Whatever true bits appear in `bits` or the expression are returned.
5. Explain in detail this code: `bits &= (1 << index);`.
  - 1 is left shifted by the value in `index`.
  - Whatever bits are true in the expression and `bits` are returned.
6. How does C# interpret this? `bool peek = bits[n];`.
  - This statement is converted to a call to the get accessor for bits, and the index argument is set to 6.
  - `peek` is set to true or false, 1 or 0.
7. How does C# interpret this? `bits[n] = true;`.
  - The index arguement is set to 1.
  - For example, if `n = 5` then the 4th letter from the right would be set to 1.
8. How does C# interpret this? `bits[n] ^= true;`.
  - If `n` is True, then the compound assignment logical exclusive OR assigns it a false value.
  - If `n` is false, it will be assigned true.
9. Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0 // No permissions
(b) permission = 1 // Read only
(c) permission = 2 // Write only
(d) permission = 3 // Read and Write only
(e) permission = 4 // Read and Write only
(f) permission = 5 // Read and Write only
(g) permission = 6 // Read, Write and Execute
(h) permission = 7 // Read, Write and Execute
10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this shceme of permissions?
(a) permission = 0 // 0000
(b) permission = 1 // 0001
(c) permission = 2 // 0010
(d) permission = 3 // 0011
(e) permission = 4 // 0100
(f) permission = 5 // 0101
(g) permission = 6 // 0110
(h) permission = 7 // 0111