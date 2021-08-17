
first = 1
second = 2 
lessThan4Mil = True
sumOfEvenValues = 2

while lessThan4Mil:
    new = first + second
    print(f'First: {first} - Second: {second} - New: {new}')
    if new > 4000000:
        lessThan4Mil = False
    elif new % 2 == 0:
        sumOfEvenValues += new
        print(f'Value is even: {new}')

    first = second
    second = new

print(f'Sum: {sumOfEvenValues}')