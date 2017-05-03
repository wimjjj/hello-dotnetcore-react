import React from "react";

import Task from "./Task";

export default class Tasks extends React.Component{

    render(){
        let tasks = this.props.tasks;

        let noteDone = tasks.filter(task => task.done == false);
        let notDoneElems = noteDone.map(task => <Task key={task.id} task={task} updateTask={this.props.updateTask} deleteTask={this.props.deleteTask} />);

        let done = tasks.filter(task => task.done == true);
        let doneElems = done.map(task => <Task key={task.id} task={task} updateTask={this.props.updateTask} deleteTask={this.props.deleteTask} />);

        return <div>
                {notDoneElems}
                {doneElems}    
            </div>;
    }
}