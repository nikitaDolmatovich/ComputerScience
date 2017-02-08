//
//  main.swift
//  Lesson1
//
//  Created by Nikita on 07.02.17.
//  Copyright © 2017 User. All rights reserved.
//

var fib = Fibonacci()

print("Number of fibonacci = \(fib.calcRecursion(itemCount: 10)) recursion")
print("Number of fibonacci = \(fib.calcCycle(itemCount: 10)) with cycle")
print("Number of fibonacci = \(fib.calcWithArray(itemCount: 10)) with array")
print("Balance = \(fib.calcBalance(n:1000000000001 , m: 99999))")


