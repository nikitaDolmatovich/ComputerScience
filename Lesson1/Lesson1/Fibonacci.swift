//
//  Fibonacci.swift
//  Lesson1
//
//  Created by Nikita on 07.02.17.
//  Copyright © 2017 User. All rights reserved.
//


class Fibonacci {
    
    private var array = [Int](repeatElement(0, count: 100))
    
    init() {}
    
    public func calcRecursion(itemCount : Int) -> Int {
        if testFirstOrSecond(itemCount: itemCount) {
            return 1
        } else {
            return calcRecursion(itemCount: itemCount - 1) + calcRecursion(itemCount: itemCount - 2)
        }
    }
    
    public func calcCycle(itemCount : Int) -> Int {
        var result : Int = 0
        var first : Int = 1
        var second : Int = 1
        
        if testFirstOrSecond(itemCount: itemCount) {
            return 1
        } else {
            for _ in 2..<itemCount {
                result = first + second
                first = second
                second = result
            }
            return result
        }
        
    }
    
    public func calcWithArray(itemCount : Int) -> CLongLong {
        if array[itemCount] == 0 {
            if testFirstOrSecond(itemCount: itemCount) {
                array[itemCount] = 1
            } else {
                array[itemCount] = Int(calcWithArray(itemCount: itemCount - 2) + calcWithArray(itemCount: itemCount - 1))
            }
        }
        
        return CLongLong(array[itemCount])
    }
    
    public func calcBalance(n : Int, m : Int) -> Int64 {
        var sequence = getPeriod(m: m)
        let period = sequence.count - 2
        let value = Int(n % period)
        
        return Int64(sequence[value])
    }
    
    private func getPeriod(m : Int) -> [Int] {
        var cache : [Int] = [Int]()
        cache.append(0)
        cache.append(1)
        for i in 2..<m*6 {
            cache.append((cache[i - 1] + cache [i - 2]) % m)
            
            if cache[i] == 1 && cache[i - 1] == 0 {
                break
            }
        }
        
        return cache
    }
    
    private func testFirstOrSecond(itemCount : Int) -> Bool {
        if itemCount == 1 || itemCount == 2 {
            return true
        } else {
            return false
        }
    }
    
    
}
