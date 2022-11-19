import React, { useState, useEffect } from 'react';
// import Planilha from "./assets/planilha.jpg"
// import { Modal, ModalBody, ModalFooter, ModalHeader } from 'reactstrap'
// import "bootstrap/dist/css/bootstrap.min.css/";
// import 'bootstrap/dist/css/bootstrap.min.css'
import axios from "axios";

const AlunoListagem = () => {
    const baseUrl = "https://localhost:44339/api/aluno";

    const [ data, setData ] = useState([]);

    const pedidoGet = async () => {
        await axios.get(baseUrl)
            .then(respose => {
                setData(respose.data);
            }).catch(error => {
                console.log(error);
        })
    }
    useEffect(() => {
        pedidoGet();
    })

    return (
        <div className="uk-container uk-width-auto">
            <div className="uk-width-auto">
                <br />
                <header className="App-header">
                    {/* <img className="width: 2px" src={Planilha} alt='Planilha'/> */}
                </header>
                <table className="uk-table uk-table-hover uk-table-divider">
                    <thead className="uk-table uk-table-hover uk-table-divider">
                        <tr className='uk-animation-scale-down'>
                            <th className='uk-text-bold'>Ativo</th>
                            {/* <th className='uk-text-bold'>Ativo</th> */}
                            <th className='uk-text-bold'>Nome</th>
                            <th className='uk-text-bold'>Idade</th>
                            <th className='uk-text-bold'>Email</th>
                            <th className='uk-text-bold'>Editar</th>
                            <th className='uk-text-bold'>Excluir</th>
                        </tr>
                    </thead>
                    <tbody>
                        {data.map(aluno => (
                            <tr key={aluno.id} className='uk-animation-scale-down'>
                                <td >{aluno.ativo}</td>
                                <td >{aluno.nome}</td>
                                <td >{aluno.idade}</td>
                                <td >{aluno.email}</td>
                                <td >
                                    <button className="uk-icon-button uk-button-primary" uk-icon='file-edit'></button>
                                </td>
                                <td>
                                    <button className="uk-icon-button uk-button-danger" uk-icon='trash'></button>
                                </td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        </div>
    )
}

export default AlunoListagem;
