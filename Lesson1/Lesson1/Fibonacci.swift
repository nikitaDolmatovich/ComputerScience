//
//  Fibonacci.swift
//  Lesson1
//
//  Created by Nikita on 07.02.17.
//  Copyright © 2017 User. All rights reserved.
//

class Fibonacci {
    init() {}
    
    func calcRecursion(itemCount : Int) -> Int {
        if itemCount == 1 || itemCount == 2 {
            return 1
        } else {
            return calcRecursion(itemCount: itemCount - 1) + calcRecursion(itemCount: itemCount - 2)
        }
    }
}
