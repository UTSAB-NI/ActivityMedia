import react from 'react';

import {Duck} from './demo';

interface Props{
    duck:Duck;
}
export function DuckItem(props:Props){
return (
        <div>
            <span>{props.duck.name}</span>
            <button onClick={()=>props.duck.makeSound(props.duck.name + 'quack')}>Make Sound</button>

           </div>
)

}

