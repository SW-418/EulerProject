
import math


def main():
    print(bruteForcePalindrome(999, 999))
    

def bruteForcePalindrome(inner, outer):
    max = 0

    for i in range(outer, 100, -1):
        for j in range(inner, 100, -1):
            multipliedValue = i * j
            # print(f'Outer: {i} - Inner: {j} - Multiplied: {multipliedValue}')
            palindrome = isPalindrome(str(multipliedValue))
            # print(f'Palindrome found: {palindrome}')
            if palindrome:
                if multipliedValue > max:
                    max = multipliedValue
                    print(f'New high: {multipliedValue} - {i} * {j}')
    return max

def isPalindrome(input):
    length = len(input)
    index = 0
    while index < math.floor(length / 2):
        if input[index] != input[(length - 1) - index]:
            return False
        index += 1
    return True

if __name__ == "__main__":
    main()

