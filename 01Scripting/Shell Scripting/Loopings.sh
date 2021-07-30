#! /usr/bin/bash
# ARRAYS
# plang=('C' 'C++' 'Java' 'C#' 'Python' 'JavaScript')
# plang[60]="Ruby"
# unset plang #[1]
# echo "first element - ${plang[0]}"
# echo "Indexes - ${!plang[@]}"
# echo "All elements - ${plang[@]}"
# echo "Length - ${#plang[@]}"

# string="Pushpinder"
# echo "${string[@]}"
# echo "${#string[@]}"
# echo "${string[0]}"
# echo "${string[1]}"

## LOOPS IN BASH
# WHILE LOOP
# while [condition]
# do
#     statement(s)
# done

n=1
#while [ $n -le 10 ]
while  (($n <= 10)) 
do
if [ $(( n%2 )) -eq 0 ]
then
   echo "$n"
fi
   #n=$(( n+1 ))
   (( n++ ))
done