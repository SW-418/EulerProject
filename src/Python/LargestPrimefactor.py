import math

def main():
    input = 600851475143
    calculate(input)

def calculate(input):
    for i in range (1, input): 
        if input % i == 0:
            res = input / i
            print(f'Divider: {i} - Result: {res} - IsPrime: {isPrimeNumber(int(res))}')

def isPrimeNumber(input): 
    for i in range(2, input):
        if input % i == 0:
            return False
    return True
    
if __name__ == "__main__":
    main()

