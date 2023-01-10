import { cliente } from "./cliente";
import { movimentacoes } from "./movimentacoes";

export class relatorio {
    totalMov!: number;
    totalImportacao!: number;
    totalExportacao!: number;
    totalConteiner!: number;
    movimentacoes!: movimentacoes[];

}