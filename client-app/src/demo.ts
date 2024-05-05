export interface Duck{
    name:string,
    numLeg:number,
    makeSound:(sound:string)=>void;

}

const duck1:Duck={
    name:"utsab",
    numLeg:2,
    makeSound:(sound: any)=>console.log(sound)
}

const duck2:Duck={
    name:"sankalpa",
    numLeg:4,
    makeSound:(sound: any)=>console.log(sound)
}

duck1.makeSound('quack');

export const ducks=[duck1,duck2];

