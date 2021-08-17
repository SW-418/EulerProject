
def main():
    print(calculateSmallestFactor(20))

def calculateSmallestFactor(input):
    allMultiples = False

    counter = 1
    while not allMultiples:
        currentValue = counter * input
        if not ensureDivisibility(currentValue, input):
            counter += 1
        else:
            return currentValue


def ensureDivisibility(input, maxValue):
    for i in range (1, maxValue + 1):
        if input % i != 0:
            return False
    return True

def isDivisibleBy(input, divisor):
    return input % divisor == 0
    

if __name__ == "__main__":
    main()

