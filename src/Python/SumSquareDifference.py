
def main():
    sumOfSquares = 0
    sum = 0

    for i in range (1, 101):
        sumOfSquares += i * i
        sum += i
    
    sum = sum * sum

    print(f'Sum of Squares: {sumOfSquares} - Sum: {sum} - Difference: {sum - sumOfSquares}')


if __name__ == "__main__":
    main()