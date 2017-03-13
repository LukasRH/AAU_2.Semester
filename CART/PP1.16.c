ASEMBLY
cond:
  testq     %rdi,   %rdi        // Tjekker om %rdi er lig med 0
  je        .L1                 // Hvis %rdi = 0 så goto .L1
  cmpq      %rdi,   (%rsi)      // Hvis (%rsi) <= %rdi
  jle       .L1                 // hvis false goto .L1
  movq      %rdi,   (%rsi)      // Tager værdien af %rdi og liger over i (%rsi)

.L1:                            // 
  rep; ret                      // 

C Code

int void cont(short a short *p)
{
    if (a == 0)
    {
        goto L1;
    } else if (*p >= a)
    {
        goto L1;
    } else
    {
        *p = a;
    }

    L1: return;
}
