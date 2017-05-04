import React from "react";

import TasksApi from "./../Api/TasksApi";

export default class Addtask extends React.Component{

    constructor() {
        super();

        this.state = {labels: []}

        TasksApi.getLabels().then((labels) => this.setState({labels}));
    }
    
    addTask(e){
        let titleInput = document.getElementById("title");
        let title = titleInput.value;
        titleInput.value= "";

        let labelID = document.getElementById("label").value;

        let task = {
            title,
            done: false,
            labelID,
        };

        this.props.addTask(task);
    }

    render(){
        return (
            <div class="row">
                <form onSubmit={function(e){e.preventDefault()}}>
                    <div class="eight columns">
                        <input type="text" name="title" id="title" placeholder="new task" class="u-full-width" autoFocus/>
                    </div>
                    <div class="two columns">
                        <select id="label" class="u-full-width">
                            {this.state.labels.map((label => <option value={label.id} key={label.id}>{label.title}</option>))}
                        </select>
                    </div>
                    <div class="two columns">
                        <button onClick={this.addTask.bind(this)} class="button button-primary u-full-width">add</button>
                    </div>
                </form>
            </div>
        );
    }
}