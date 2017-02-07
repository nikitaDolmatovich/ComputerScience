//
//  Fibonacci.swift
//  Lesson1
//
//  Created by Nikita on 07.02.17.
//  Copyright © 2017 User. All rights reserved.
//

class Fibonacci {
    
    private var array = [Int](repeatElement(0, count: 100))
    private var cache = [Int]()
    
    init() {}
    
    public func calcRecursion(itemCount : Int) -> Int {
        if testFirstOrSecond(itemCount: itemCount) {
            return 1
        } else {
            return calcRecursion(itemCount: itemCount - 1) + calcRecursion(itemCount: itemCount - 2)
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
    
    private func testFirstOrSecond(itemCount : Int) -> Bool {
        if itemCount == 1 || itemCount == 2 {
            return true
        } else {
            return false
        }
    }
    
}
