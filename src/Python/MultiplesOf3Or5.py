sum = 0
lessThan10003 = True
lessThan1005 = True

multiplier = 1

while lessThan10003 or lessThan1005:
    three = 3 * multiplier
    five = 5 * multiplier
    fifteen = 15 * multiplier
    if lessThan10003:
        if three < 1000:
            print(f'Three: {three}')
            sum += three
        else:
            lessThan10003 = False
    if lessThan1005:
        if five < 1000:
            print(f'Five: {five}')
            sum += five
        else:
            lessThan1005 = False
    
    if fifteen < 1000:
        sum-=fifteen
    multiplier += 1

print(sum)
