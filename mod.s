.386
.model flat

start:

MOV EAX, 0x08
SUB 2
DUP EAX
ADD EAX
ADD EDX, EDX

MOV EBX, EIP

NOP
NOP
NOP

RET
